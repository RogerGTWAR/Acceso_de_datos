using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net
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
            makesForm.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            InventarioForm inventarioForm = new InventarioForm();
            inventarioForm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
