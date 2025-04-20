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
                while (imagenes.lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.ImagenUrl = (string)imagenes.lector["ImagenUrl"];
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
                while (datos.lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Codigo = (string)datos.lector["Codigo"];
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Categoria = new Categoria();
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                        aux.Categoria.Descripcion = (string)datos.lector["Categoria"];
                    else aux.Categoria.Descripcion = "";
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.lector["Marca"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Imagenes = ListarImagen(aux.Id);
                    lista.Add(aux);
                }
                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarArticulo(Articulo nuevo)
        {
            ConexionDB datos = new ConexionDB();

            try
            {
                // Insertar artículo y obtener el Id generado
                datos.setConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                  "OUTPUT INSERTED.Id " +
                                  "VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio)");

                datos.setParametro("@codigo", nuevo.Codigo);
                datos.setParametro("@nombre", nuevo.Nombre);
                datos.setParametro("@descripcion", nuevo.Descripcion);
                datos.setParametro("@idMarca", nuevo.Marca.Id);
                datos.setParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setParametro("@precio", nuevo.Precio);

                int idArticulo = datos.ejecutarScalar(); // método que devuelve el ID insertado

                datos.cerrarConexion();

                // Insertar imágenes asociadas
                if (nuevo.Imagenes != null && nuevo.Imagenes.Count > 0)
                {
                    foreach (Imagen img in nuevo.Imagenes)
                    {
                        ConexionDB imagenDB = new ConexionDB();
                        imagenDB.setConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @url)");
                        imagenDB.setParametro("@idArticulo", idArticulo);
                        imagenDB.setParametro("@url", img.ImagenUrl);
                        imagenDB.ejecutarAccion();
                        imagenDB.cerrarConexion();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}