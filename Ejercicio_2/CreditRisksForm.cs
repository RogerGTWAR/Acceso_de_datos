using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_2.Models;
//Recordar arreglar el error en actualizar(no se actualiza el id de los customers

namespace Ejercicio_2
{
    public partial class CreditRisksForm : Form
    {
        private readonly CustomersRepository _customersRepository;
        private readonly CreditRisksRepository _creditRisksRepository;
        public CreditRisksForm()
        {
            InitializeComponent();
            _customersRepository = new CustomersRepository();
            _creditRisksRepository = new CreditRisksRepository();
            RefreshData();
        }

        private void RefreshData()
        {
            dgvCreditRisks.DataSource = _creditRisksRepository.GetAll();
            LoadAuthors();
        }

        private void LoadAuthors()
        {
            List<Customer> customers = _customersRepository.GetAll();
            CbCustomer.DataSource = customers;
            CbCustomer.DisplayMember = "Id";
            CbCustomer.ValueMember = "Id";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //string nuevoNombre = txtNombre.Text;
            //string nuevoApellido = txtApellido.Text; // Nuevo TextBox para otro string

            //if (string.IsNullOrEmpty(nuevoNombre))
            //{
            //    MessageBox.Show("Por favor, ingrese un nuevo título para el libro.");
            //}
            //if (string.IsNullOrEmpty(nuevoApellido))
            //{
            //    MessageBox.Show("Por favor, ingrese un nuevo título para el libro.");
            //}
            //else
            //{
            //    // Cambiamos el tipo de la clase Book a CreditRisk
            //    CreditRisk bookSeleccionado = dgvCreditRisks.CurrentRow?.DataBoundItem as CreditRisk;
            //    if (bookSeleccionado != null)
            //    {
            //        // Cambiamos el tipo de la clase Author a Customer
            //        Customer authorSeleccionado = CbCustomer.SelectedItem as Customer;
            //        if (authorSeleccionado != null)
            //        {
            //            bookSeleccionado.FirstName = nuevoNombre;
            //            // Asignamos el objeto Customer seleccionado a la propiedad Customer de CreditRisk
            //            bookSeleccionado.Customer = authorSeleccionado;
            //            // Asignamos el nuevo campo de texto al libro
            //            bookSeleccionado.LastName = nuevoApellido;

            //            _creditRisksRepository.Update(bookSeleccionado);
            //            RefreshData();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Por favor, seleccione un autor para el libro.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Por favor, seleccione un libro de la lista.");
            //    }
            string nuevoNombre = txtNombre.Text;
            string nuevoApellido = txtApellido.Text;

            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("Por favor, ingrese un nuevo título para el Credit Risks.");
            }
            else if (string.IsNullOrEmpty(nuevoApellido))
            {
                MessageBox.Show("Por favor, ingrese un nuevo apellido para el Credit Risks.");
            }
            else
            {
                CreditRisk bookSeleccionado = dgvCreditRisks.CurrentRow?.DataBoundItem as CreditRisk;
                if (bookSeleccionado != null)
                {
                    Customer authorSeleccionado = CbCustomer.SelectedItem as Customer;
                    if (authorSeleccionado != null)
                    {
                        bookSeleccionado.FirstName = nuevoNombre;
                        bookSeleccionado.Customer = authorSeleccionado;
                        bookSeleccionado.LastName = nuevoApellido;
                        bookSeleccionado.CustomerId = authorSeleccionado.CustomerId;

                        _creditRisksRepository.Update(bookSeleccionado);
                        RefreshData();
                        MessageBox.Show("Libro actualizado correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un autor para el libro.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un libro de la lista.");
                }
            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCreditRisks.SelectedRows.Count > 0)
            {
                CreditRisk creditRisk = dgvCreditRisks.SelectedRows[0].DataBoundItem as CreditRisk;
                _creditRisksRepository.Delete(creditRisk.Id);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un libro para eliminar.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text; // Agregar esta línea

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido)) // Modificar esta condición
            {
                Customer customerSeleccionado = CbCustomer.SelectedItem as Customer;
                if (customerSeleccionado != null)
                {
                    var creditRisk = new CreditRisk { FirstName = nombre, LastName = apellido, CustomerId = customerSeleccionado.Id }; // Modificar esta línea
                    _creditRisksRepository.Add(creditRisk);
                    MessageBox.Show("Libro agregado correctamente.");

                    txtNombre.Text = string.Empty;
                    txtApellido.Text = string.Empty; // Agregar esta línea para limpiar el campo de apellido
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un autor para el libro.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el título y el apellido del autor del libro.");
            }
            RefreshData();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CreditRisksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
