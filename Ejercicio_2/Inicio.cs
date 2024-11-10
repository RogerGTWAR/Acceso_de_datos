using Ejercicio_2;

namespace Ejercicio1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.TopLevel = false;
            customersForm.FormBorderStyle = FormBorderStyle.None;

            customersForm.Dock = DockStyle.Fill;
            Panel.Controls.Add(customersForm);
            customersForm.Show();
        }

        private void btnCreditRisks_Click_1(object sender, EventArgs e)
        {
            CreditRisksForm creditRisksForm = new CreditRisksForm();
            creditRisksForm.TopLevel = false;
            creditRisksForm.FormBorderStyle = FormBorderStyle.None;

            creditRisksForm.Dock = DockStyle.Fill;
            Panel2.Controls.Add(creditRisksForm);
            creditRisksForm.Show();
        }
    }
}
