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
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void btnCreditRisks_Click(object sender, EventArgs e)
        {
            CreditRisksForm creditRisksForm = new CreditRisksForm();
            creditRisksForm.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
