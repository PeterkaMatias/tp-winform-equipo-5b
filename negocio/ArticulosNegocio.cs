using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Imagen> ListarImagen(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            ConexionDB imagenes = new ConexionDB();

            imagenes.setConsulta("select ImagenUrl from Imagenes where IdArticulo = " + idArticulo + ";");
            imagenes.ejecutarLectura();

            try
            {
                int contador = 0;
                while (imagenes.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.ImagenUrl = (string)imagenes.Lector["ImagenUrl"];
                    aux.numeroImagen = contador += 1;
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            ConexionDB datos = new ConexionDB();
            try
            {
                datos.setConsulta("select a.Id, Codigo, Nombre, a.Descripcion, M.Descripcion as marca, a.IdCategoria, C.Descripcion as categoria, Precio from ARTICULOS A left join MARCAS M on a.IdMarca = M.Id left join CATEGORIAS C on A.IdCategoria = c.Id;");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Categoria = new Categoria();
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Categoria"))))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    else aux.Categoria.Descripcion = "";
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenUrl = ListarImagen(aux.Id);
                    lista.Add(aux);
                }
                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}