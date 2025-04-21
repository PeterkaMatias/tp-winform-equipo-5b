using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace TPWinForm_equipo_5B
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnListarArticulo_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms.Cast<Form>().ToList())
            {
                if (item.GetType() == typeof(frmListaArticulos))
                {
                    MessageBox.Show("La ventana ya está abierta.");
                    item.Focus();
                    return;
                }
            }

            frmListaArticulos ventana = new frmListaArticulos();
            ventana.Show();
        }
        private void btnBusquedaArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms.Cast<Form>().ToList())
            {
                if (item.GetType() == typeof(frmAgregarArticulo))
                {
                    MessageBox.Show("La ventana ya está abierta.");
                    item.Focus();
                    return;
                }
            }

            frmAgregarArticulo ventana = new frmAgregarArticulo();
            ventana.Show();
        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {

        }
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms.Cast<Form>().ToList())
            {
                if (item.GetType() == typeof(frmEliminarArticulo))
                {
                    MessageBox.Show("La ventana ya está abierta.");
                    item.Focus();
                    return;
                }
            }

            frmEliminarArticulo ventana = new frmEliminarArticulo();
            ventana.Show();
        }
        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms.Cast<Form>().ToList())
            {
                if (item.GetType() == typeof(frmDetalleArticulo))
                {
                    MessageBox.Show("La ventana ya está abierta.");
                    item.Focus();
                    return;
                }
            }

            frmDetalleArticulo ventana = new frmDetalleArticulo();
            ventana.Show();
        }

    }
}
