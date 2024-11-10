using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entity_Framework
{
    public partial class CustomerForm : Form
    {
        private CustomersRepository customersRepository;
        public CustomerForm()
        {
            InitializeComponent();
            customersRepository = new CustomersRepository();
            RefreshData();
        }

        private void RefreshData()
        {
           dgvCustomer.DataSource = customersRepository.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtFirstName.Text;
            string nuevoApellido = txtLastName.Text;
            Customer clienteSeleccionado = dgvCustomer.SelectedRows.Count > 0 ? dgvCustomer.SelectedRows[0].DataBoundItem as Customer : null;

            bool ValidarEntradas(string nombre, string apellido, Customer customer)
            {
                if (customer == null)
                {
                    MessageBox.Show("Por favor, seleccione un cliente de la lista.");
                    return false;
                }
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Por favor, ingrese un nuevo nombre para el cliente.");
                    return false;
                }
                if (string.IsNullOrEmpty(apellido))
                {
                    MessageBox.Show("Por favor, ingrese un nuevo apellido para el cliente.");
                    return false;
                }
                return true;
            }

            void Actualizar(Customer customer, string nombre, string apellido)
            {
                customer.FirstName = nombre;
                customer.LastName = apellido;
                try
                {
                    customersRepository.Update(customer);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar");
                }
            }

            if (ValidarEntradas(nuevoNombre, nuevoApellido, clienteSeleccionado))
            {
                Actualizar(clienteSeleccionado, nuevoNombre, nuevoApellido);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                Customer customer = dgvCustomer.SelectedRows[0].DataBoundItem as Customer;
                customersRepository.Delete(customer.Id);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un autor para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = txtFirstName.Text;
            string apellidoBusqueda = txtLastName.Text;

            List<Customer> clienteEncontrado;

            if (!string.IsNullOrEmpty(nombreBusqueda) && !string.IsNullOrEmpty(apellidoBusqueda))
            {
                clienteEncontrado = customersRepository.GetByNameandLastName(nombreBusqueda, apellidoBusqueda);
            }
            else if (!string.IsNullOrEmpty(nombreBusqueda))
            {
                clienteEncontrado = customersRepository.GetByName(nombreBusqueda);
            }
            else if (!string.IsNullOrEmpty(apellidoBusqueda))
            {
                clienteEncontrado = customersRepository.GetByLastName(apellidoBusqueda);
            }
            else
            {
                RefreshData();
                return;
            }
            dgvCustomer.DataSource = clienteEncontrado;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            customersRepository.Add(customer);
            RefreshData();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
