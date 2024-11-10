using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void btnMakes_Click(object sender, EventArgs e)
        {
            MakesForm makesForm = new MakesForm();
            makesForm.TopLevel = false;
            makesForm.FormBorderStyle = FormBorderStyle.None;

            makesForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(makesForm);
            makesForm.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            InventarioForm inventarioForm = new InventarioForm();
            inventarioForm.TopLevel = false;
            inventarioForm.FormBorderStyle = FormBorderStyle.None;

            inventarioForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(inventarioForm);
            inventarioForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
