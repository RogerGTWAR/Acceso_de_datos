using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_1.Models;

namespace Ejercicio_1
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
            LoadMakes();
            if (id != null)
            {
                Cargar();
            }
        }

        private void LoadMakes()
        {
            List<Make> makes = _makeRepository.GetAll();
            CbMake.DataSource = makes;
            CbMake.DisplayMember = "Name";
            CbMake.ValueMember = "MakeId";
        }

        private void Cargar()
        {
            if (_id.HasValue)
            {
                Inventario inventario = _inventarioRepository.GetValue((int)_id);
                txtColor.Text = inventario.Color;
                txtPetName.Text = inventario.PetName;
                CbMake.SelectedValue = inventario.MakeId;
            }
        }

        private void RefreshData()
        {
            dgvInventario.DataSource = _inventarioRepository.GetAll();
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
            if (dgvInventario.SelectedRows.Count > 0 && dgvInventario.SelectedRows[0].Cells[0].Value != null)
                return Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[0].Value);
            return null;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                _inventarioRepository.Add(new Inventario
                {
                    MakeId = (int)CbMake.SelectedValue,
                    Color = txtColor.Text,
                    PetName = txtPetName.Text,
                });
            }
            else
            {
                _inventarioRepository.Update(new Inventario
                {
                    Id = (int)_id,
                    MakeId = (int)CbMake.SelectedValue,
                    Color = txtColor.Text,
                    PetName = txtPetName.Text,
                });
            }
            RefreshData();
        }


        private void InventarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtPetName.Text;
            List<Inventario> inventariosEncontrados = _inventarioRepository.SearchByPetName(textoBusqueda);
            dgvInventario.DataSource = inventariosEncontrados;

        }

        private void CbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selectedMakeId = (int)CbMake.SelectedValue;
            //List<Inventario> filteredInventarios = _inventarioRepository.GetByMakeId(selectedMakeId);
            //dgvInventario.DataSource = filteredInventarios;
        }
    }
}
