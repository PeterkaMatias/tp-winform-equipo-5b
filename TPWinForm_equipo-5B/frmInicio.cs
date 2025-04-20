using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmInicio))
                {
                    MessageBox.Show("Ventana abierta.");
                    return;
                }
            }
        }
        private void btnBusquedaArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {

        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {

        }
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

        }
        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
