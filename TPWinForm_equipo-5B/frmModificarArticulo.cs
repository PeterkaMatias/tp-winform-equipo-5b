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
    public partial class frmModificarArticulo : Form
    {
        public frmModificarArticulo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int id = (int)numeroID.Value;
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = negocio.DetalleArticulo(id);

            if (articulo.Id == 0)
            {
                MessageBox.Show("Artículo no encontrado.");
                tbxCodigo.Text = "";
                tbxNombre.Text = "";
                tbxDescripcion.Text = "";
                numeroPrecio.Value = 0;
                tbxImagenURL.Text = "";
                numeroMarca.Value = 0;
                numeroCategoria.Value = 0; 
                return;
            }

            tbxCodigo.Text = articulo.Codigo;
            tbxNombre.Text = articulo.Nombre;
            tbxDescripcion.Text = articulo.Descripcion;
            numeroPrecio.Value = articulo.Precio;
            tbxImagenURL.Text = articulo.Imagenes.Count > 0 ? articulo.Imagenes[0].ImagenUrl : "";
            numeroMarca.Value = articulo.Marca.Id;
            numeroCategoria.Value = articulo.Categoria.Id;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();

            articulo.Id = (int)numeroID.Value;
            articulo.Codigo = tbxCodigo.Text;
            articulo.Nombre = tbxNombre.Text;
            articulo.Descripcion = tbxDescripcion.Text;
            articulo.Precio = (int)(numeroPrecio.Value);

            articulo.Marca = new Marca();
            articulo.Marca.Id = (int)numeroMarca.Value; 

            articulo.Categoria = new Categoria();
            articulo.Categoria.Id = (int)numeroCategoria.Value;

            articulo.Imagenes = new List<Imagen>();
            if (!string.IsNullOrWhiteSpace(tbxImagenURL.Text))
            {
                articulo.Imagenes.Add(new Imagen { ImagenUrl = tbxImagenURL.Text });
            }

            try
            {
                negocio.ModificarArticulo(articulo);
                MessageBox.Show("Artículo modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

    }
}
