using Ado.Net.Models;
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ado.Net
{
    public partial class MakesForm : Form
    {
        private readonly IRepository<Make> makeRepository;

        public MakesForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            makeRepository = new MakeRepository(connectionString);

            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                dgvMakes.DataSource = makeRepository.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de fabricantes");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Make newMake = new Make
                {
                    Name = txtNombre.Text
                };
                makeRepository.Add(newMake);
                RefreshData();
                txtNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el fabricante");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMakes.CurrentRow != null)
                {
                    Make selectedMake = (Make)dgvMakes.CurrentRow.DataBoundItem;
                    selectedMake.Name = txtNombre.Text;
                    makeRepository.Update(selectedMake);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el fabricante");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetSeleccionado();
            try
            {
                if (id.HasValue)
                {
                    makeRepository.Delete(id.Value);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar makes, porque se esta utilizando en la tabla Inventory");
            }
        }
        private int? GetSeleccionado()
        {
            if (dgvMakes.SelectedRows.Count > 0 && dgvMakes.SelectedRows[0].Cells[0].Value != null)
                return Convert.ToInt32(dgvMakes.SelectedRows[0].Cells[0].Value);
            return null;
        }
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            string color = txtNombre.Text; //Realice esto para solucionar los parametros y que el InventarioForm pueda buscar tambien con colores :)
            if (string.IsNullOrEmpty(name))
            {
                RefreshData();
            }
            else
            {
                var makes = makeRepository.GetByName(name, color).ToList();
                dgvMakes.DataSource = makes;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
