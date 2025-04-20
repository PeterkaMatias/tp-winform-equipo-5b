using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class ConexionDB
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public SqlDataReader lector { get; private set; }

        public ConexionDB()
        {
            conexion = new SqlConnection("server=localhost; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public void setConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ejecutarAccion: " + ex.Message);
            }
        }
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
        public void setParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public int ejecutarScalar()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                return (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ejecutarAccion: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ejecutarAccion: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}