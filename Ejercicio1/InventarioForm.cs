using Ejercicio_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class InventarioForm : Form
    {
        private readonly InventarioRepository _inventarioRepository;
        private readonly MakeRepository _makeRepository;
        private int? _id;
        public InventarioForm(int? id = null)
        {
            InitializeComponent();
            _id = id;
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _inventarioRepository = new InventarioRepository(connectionString);
            _makeRepository = new MakeRepository(connectionString);
            RefreshData();
            if (id != null)
            {
                Cargar();
            }
        }

        private void Cargar()
        {
            Inventario inventario = _inventarioRepository.GetValue((int)_id);
            txtColor.Text = inventario.Color;
            txtPetName.Text = inventario.PetName;
        }
        private void RefreshData()
        {
            dgv.DataSource = _inventarioRepository.GetAll();
            LoadMakes();
        }

        private void LoadMakes()
        {
            List<Make> makes = _makeRepository.GetAll();
            CbMake.DataSource = makes;
            CbMake.DisplayMember = "Name";
            CbMake.ValueMember = "AuthorId";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                _inventarioRepository.Add(new Inventario
                {
                    Color = txtColor.Text,
                    PetName = txtPetName.Text,
                });
            }
            else
            {
                _inventarioRepository.Update(new Inventario
                {
                    Color = txtColor.Text,
                    PetName = txtPetName.Text,
                    Id = (int)_id,
                });
            }
            RefreshData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetSeleccionado();
            if (id != null)
            {
                _inventarioRepository.Delete((int)id);
                RefreshData();
            }
        }

        private int? GetSeleccionado()
        {
            if (dgv.SelectedRows.Count > 0 && dgv.SelectedRows[0].Cells[0].Value != null)
                return Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            return null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void InventarioForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
