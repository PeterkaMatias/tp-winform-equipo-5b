using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Imagen> Imagenes { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }

        public string ImagenUrl
        {
            get
            {
                return (Imagenes != null && Imagenes.Count > 0) ? Imagenes[0].ImagenUrl : null;
            }
        }
    }
}
