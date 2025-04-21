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
    public partial class frmDetalleArticulo : Form
    {
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int id = (int)numeroID.Value;

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                Articulo articulo = negocio.DetalleArticulo(id); 

                lblCodigo.Text = "Codigo = " + articulo.Codigo;
                lblNombre.Text = "Nombre = " + articulo.Nombre;
                lblDescripcion.Text = "Descripcion = " + articulo.Descripcion;
                lblPrecio.Text = "Precio = " + articulo.Precio.ToString("C"); 
                lblCategoria.Text = "Categoria = " + articulo.Categoria.Descripcion;
                lblMarca.Text = "Marca = " + articulo.Marca.Descripcion;

                if (articulo.Imagenes.Count > 0)
                {
                    pictureBoxArticulo.ImageLocation = articulo.Imagenes[0].ImagenUrl; 
                }
                else
                {
                    pictureBoxArticulo.Image = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
