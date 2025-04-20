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
    public partial class frmListaArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public frmListaArticulos()
        {
            InitializeComponent();
        }

        private void frmListaArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.Listar();

            dgvArticulos.DataSource = listaArticulos;

            dgvArticulos.Columns["ImagenUrl"].HeaderText = "Imagen";
            dgvArticulos.Columns["Id"].HeaderText = "ID";
            dgvArticulos.Columns["codigo"].HeaderText = "Código";
            dgvArticulos.Columns["nombre"].HeaderText = "Nombre";
            dgvArticulos.Columns["descripcion"].HeaderText = "Descripción";
            dgvArticulos.Columns["precio"].HeaderText = "Precio";
            dgvArticulos.Columns["marca"].HeaderText = "Marca";
            dgvArticulos.Columns["categoria"].HeaderText = "Categoría";
        }
    }
}
