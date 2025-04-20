using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_5B
{
    internal class ArticuloDAO
    {
        private readonly string connectionString;

        public ArticuloDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Articulo> ObtenerArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Articulos";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Articulo articulo = new Articulo
                        {
                            Codigo = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Descripcion = reader.GetString(2),
                            Precio = reader.GetDecimal(3),
                        };
                        articulos.Add(articulo);
                    }
                }
            }
            return articulos;
        }
    }
}
