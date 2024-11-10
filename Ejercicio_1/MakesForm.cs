using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_1.Models;

namespace Ejercicio_1
{
    public partial class MakesForm : Form
    {
        private MakeRepository _makeRepository;
        private int? _id;
        public MakesForm(int? id = null)
        {
            InitializeComponent();
            _id = id;
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _makeRepository = new MakeRepository(connectionString);
            RefreshData();
            if (id != null)
            {
                Cargar();
            }
        }

        private void Cargar()
        {
            Make make = _makeRepository.GetValue((int)_id);
            txtNombre.Text = make.Name;
        }

        private void RefreshData()
        {
            dgvMakes.DataSource = _makeRepository.GetAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                _makeRepository.Add(new Make
                {
                    Name = txtNombre.Text,
                });
            }
            else
            {
                _makeRepository.Update(new Make
                {
                    Name = txtNombre.Text,
                    Id = (int)_id,
                });
            }
        }

        private void Eliminar()
        {
            int? id = GetSeleccionado();
            if (id != null)
            {
                _makeRepository.Delete((int)id);
                RefreshData();
            }
        }

        private int? GetSeleccionado()
        {
            if (dgvMakes.SelectedRows.Count > 0 && dgvMakes.SelectedRows[0].Cells[0].Value != null)
                return Convert.ToInt32(dgvMakes.SelectedRows[0].Cells[0].Value);
            return null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
