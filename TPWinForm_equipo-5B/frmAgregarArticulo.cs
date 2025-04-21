using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_5B
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void tbxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar < '1' || e.KeyChar > '8'))
            {
                e.Handled = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo
            {
                Codigo = tbxCodigo.Text,
                Nombre = tbxNombre.Text,
                Descripcion = tbxDescripcion.Text,
                Marca = new Marca { Id = (int)numeroMarcaBox.Value}, 
                Categoria = new Categoria { Id = (int)numeroCategoriaBox.Value}, 
                Precio = (int)numeroPrecioBox.Value
            };
            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.AgregarArticulo(nuevoArticulo);
        }
    }
}
