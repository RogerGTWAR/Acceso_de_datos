using Ejercicio_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class CustomersForm : Form
    {
        private CustomersRepository _customersRepository;
        public CustomersForm()
        {
            InitializeComponent();
            _customersRepository = new CustomersRepository();
            RefreshData();
        }

        private void RefreshData()
        {
            dgvCustomers.DataSource = _customersRepository.GetAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = txtNombre.Text,
                LastName = txtApellido.Text
            };
            _customersRepository.Add(customer);
            RefreshData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                Customer customer = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
                _customersRepository.Delete(customer.Id);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un autor para eliminar.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombre.Text;
            string nuevoApellido = txtApellido.Text;
            Customer autorSeleccionado = dgvCustomers.SelectedRows.Count > 0 ? dgvCustomers.SelectedRows[0].DataBoundItem as Customer : null;

            bool ValidarEntradas(string nombre, string apellido, Customer customer)
            {
                if (customer == null)
                {
                    MessageBox.Show("Por favor, seleccione un autor de la lista.");
                    return false;
                }
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Por favor, ingrese un nuevo nombre para el autor.");
                    return false;
                }
                if (string.IsNullOrEmpty(apellido))
                {
                    MessageBox.Show("Por favor, ingrese un nuevo apellido para el autor.");
                    return false;
                }
                return true;
            }

            void ActualizarAutor(Customer customer, string nombre, string apellido)
            {
                customer.FirstName = nombre;
                customer.LastName = apellido;
                try
                {
                    _customersRepository.Update(customer);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el autor: {ex.Message}");
                }
            }

            if (ValidarEntradas(nuevoNombre, nuevoApellido, autorSeleccionado))
            {
                ActualizarAutor(autorSeleccionado, nuevoNombre, nuevoApellido);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
