using Ejercicio_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCustumer_Click(object sender, EventArgs e)
        {
            InventarioForm inventarioForm = new InventarioForm();
            inventarioForm.TopLevel = false;
            inventarioForm.FormBorderStyle = FormBorderStyle.None;

            inventarioForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(inventarioForm);
            inventarioForm.Show();
        }

        private void btnMakes_Click(object sender, EventArgs e)
        {
            MakesForm makesForm = new MakesForm();
            makesForm.TopLevel = false;
            makesForm.FormBorderStyle = FormBorderStyle.None;

            makesForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(makesForm);
            makesForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
