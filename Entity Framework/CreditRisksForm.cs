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

namespace Entity_Framework
{
    public partial class CreditRisksForm : Form
    {
        private readonly CustomersRepository customersRepository;
        private readonly CreditRisksRepository creditRisksRepository;
        public CreditRisksForm()
        {
            InitializeComponent();
            creditRisksRepository = new CreditRisksRepository();
            customersRepository = new CustomersRepository();
            RefreshData();
        }

        private void RefreshData()
        {
            dgvCreditRisks.DataSource = creditRisksRepository.GetAll();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            List<Customer> customers = customersRepository.GetAll();
            CbCustomer.DataSource = customers;
            CbCustomer.DisplayMember = "Id";
            CbCustomer.ValueMember = "Id";
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string riesgo = txtRiesgo.Text;
            string tipo = txtTipo.Text;

            if (!string.IsNullOrEmpty(riesgo) && !string.IsNullOrEmpty(tipo))
            {
                Customer customerSeleccionado = CbCustomer.SelectedItem as Customer;
                if (customerSeleccionado != null)
                {
                    var creditRisk = new CreditRisk { FirstName = riesgo, LastName = tipo, CustomerId = customerSeleccionado.Id };
                    creditRisksRepository.Add(creditRisk);
                    MessageBox.Show("Riesgo agregado correctamente.");
                    txtRiesgo.Text = string.Empty;
                    txtTipo.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un id para el riesgos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el título y el apellido del autor del libro.");
            }
            RefreshData();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCreditRisks.SelectedRows.Count > 0)
            {
                CreditRisk creditRisk = dgvCreditRisks.SelectedRows[0].DataBoundItem as CreditRisk;
                creditRisksRepository.Delete(creditRisk.Id);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un libro para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string riesgo = txtRiesgo.Text;
            string tipo = txtTipo.Text;

            List<CreditRisk> clienteEncontrado;

            if (!string.IsNullOrEmpty(riesgo) && !string.IsNullOrEmpty(tipo))
            {
                clienteEncontrado = creditRisksRepository.GetByNameandLastName(riesgo, tipo);
            }
            else if (!string.IsNullOrEmpty(riesgo))
            {
                clienteEncontrado = creditRisksRepository.GetByName(riesgo);
            }
            else if (!string.IsNullOrEmpty(tipo))
            {
                clienteEncontrado = creditRisksRepository.GetByLastName(tipo);
            }
            else
            {
                RefreshData();
                return;
            }
            dgvCreditRisks.DataSource = clienteEncontrado;
        }

        private void CreditRisksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
//Recordar agregarle el codigo a actualizar