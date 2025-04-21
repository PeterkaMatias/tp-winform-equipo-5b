using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Collections;

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
                datos.setConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                  "OUTPUT INSERTED.Id " +
                                  "VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio)");

                datos.setParametro("@codigo", nuevo.Codigo);
                datos.setParametro("@nombre", nuevo.Nombre);
                datos.setParametro("@descripcion", nuevo.Descripcion);
                datos.setParametro("@idMarca", nuevo.Marca.Id);
                datos.setParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setParametro("@precio", nuevo.Precio);

                int idArticulo = datos.ejecutarScalar();

                datos.cerrarConexion();

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
        public void EliminarArticulo(int id)
        {
            try
            {
                ConexionDB datosImagenes = new ConexionDB();
                datosImagenes.setConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @id");
                datosImagenes.setParametro("@id", id);
                datosImagenes.ejecutarAccion();
                datosImagenes.cerrarConexion();

                ConexionDB datosArticulo = new ConexionDB();
                datosArticulo.setConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                datosArticulo.setParametro("@id", id);
                datosArticulo.ejecutarAccion();
                datosArticulo.cerrarConexion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Articulo DetalleArticulo(int id)
        {
            Articulo articulo = new Articulo();
            ConexionDB datos = new ConexionDB();
            try
            {
                datos.setConsulta("select a.Id, Codigo, Nombre, a.Descripcion, M.Descripcion as marca, a.IdCategoria, C.Descripcion as categoria, Precio " +
                                  "from ARTICULOS A " +
                                  "left join MARCAS M on a.IdMarca = M.Id " +
                                  "left join CATEGORIAS C on A.IdCategoria = C.Id " +
                                  "WHERE a.Id = @id");
                datos.setParametro("@id", id);
                datos.ejecutarLectura();

                if (datos.lector.Read()) 
                {
                    articulo.Id = (int)datos.lector["Id"];
                    articulo.Codigo = (string)datos.lector["Codigo"];
                    articulo.Nombre = (string)datos.lector["Nombre"];
                    articulo.Categoria = new Categoria();
                    if (!(datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria"))))
                        articulo.Categoria.Descripcion = (string)datos.lector["Categoria"];
                    else
                        articulo.Categoria.Descripcion = "";
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.lector["Marca"];
                    articulo.Descripcion = (string)datos.lector["Descripcion"];
                    articulo.Precio = (decimal)datos.lector["Precio"];
                    articulo.Imagenes = ListarImagen(articulo.Id);
                }
                else
                {
                    articulo.Id = 0;
                    articulo.Codigo = "No se encontro el articulo";
                    articulo.Nombre = "No se encontro el articulo";
                    articulo.Descripcion = "No se encontro el articulo";
                    articulo.Precio = 0;
                    articulo.Marca = new Marca { Descripcion = "No se encontro el articulo" };
                    articulo.Categoria = new Categoria { Descripcion = "No se encontro el articulo" };
                    articulo.Imagenes = new List<Imagen>();
                }
                return articulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}