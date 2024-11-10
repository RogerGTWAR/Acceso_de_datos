using Ado.Net.Models;
using System;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Ado.Net
{
    public partial class InventarioForm : Form
    {
        private readonly IRepository<Make> makeRepository;
        private readonly IRepository<Inventario> inventoryRepository;
        public InventarioForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            makeRepository = new MakeRepository(connectionString);
            inventoryRepository = new InventoryRepository(connectionString);
            LoadMakes();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                dgvInventario.DataSource = inventoryRepository.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del inventario");
            }
        }

        private void LoadMakes()
        {
            var makes = makeRepository.GetAll();
            CbMake.DataSource = makes;
            CbMake.DisplayMember = "Id";
            CbMake.ValueMember = "Id";
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Inventario newInventory = new Inventario
                {
                    MakeId = (int)CbMake.SelectedValue,
                    Color = txtColor.Text,
                    PetName = txtPetName.Text
                };
                inventoryRepository.Add(newInventory);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar nuevo inventario");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow != null)
                {
                    Inventario selectedInventory = (Inventario)dgvInventario.CurrentRow.DataBoundItem;
                    selectedInventory.MakeId = (int)CbMake.SelectedValue;
                    selectedInventory.Color = txtColor.Text;
                    selectedInventory.PetName = txtPetName.Text;
                    inventoryRepository.Update(selectedInventory);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el inventario");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow != null)
                {
                    Inventario selectedInventory = (Inventario)dgvInventario.CurrentRow.DataBoundItem;
                    inventoryRepository.Delete(selectedInventory.Id);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el inventario");
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string petname = txtPetName.Text;
            string color = txtColor.Text;
            if (string.IsNullOrEmpty(petname) && string.IsNullOrEmpty(color))
            {
                RefreshData();
            }
            else
            {
                var inventarios = inventoryRepository.GetByName(petname, color).ToList();
                dgvInventario.DataSource = inventarios;
            }

        }
    }
}
