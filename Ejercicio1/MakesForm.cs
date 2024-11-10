using System.Configuration;
using System.Security.Cryptography;
using Ejercicio_1;

namespace Ejercicio1
{
    public partial class MakesForm : Form
    {
        private MakeRepository _makeRepository;
        private int? _id;
        public MakesForm(int? id = null)
        {
            InitializeComponent();
            _id = id;
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _makeRepository = new MakeRepository(connectionString);
            RefreshData();
            if (id != null)
            {
                Cargar();
            }
        }

        private void Cargar()
        {
            Make make = _makeRepository.GetValue((int)_id);
            txtNombre.Text = make.Name;
        }

        private void RefreshData()
        {
            dgv.DataSource = _makeRepository.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
            int? id = GetSeleccionado();
            if (id != null)
            {
                _makeRepository.Delete((int)id);
                RefreshData();
            }

        }

        private int? GetSeleccionado()
        {
            if (dgv.SelectedRows.Count > 0 && dgv.SelectedRows[0].Cells[0].Value != null)
                return Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            return null;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            if (_id == null)
            {
                _makeRepository.Add(new Make
                {
                    Name = txtNombre.Text,
                });
            }
            else
            {
                _makeRepository.Update(new Make
                {
                    Name = txtNombre.Text,
                    Id = (int)_id,
                });
            }
        }
    }
}
