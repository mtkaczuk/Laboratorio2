using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class PaqueteDAO
    {
        #region Constructores
        public PaqueteDAO()
        {
        }
        #endregion

        #region Métodos
        public static bool Insertar(Paquete p)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True");
            try
            {
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Paquetes (DireccionEntrega, TrackingID, alumno) values (" + "'" + p.DireccionEntrega.ToString() + "', " + "'" + p.TrackingID.ToString() + "', " + "'" + "mtkaczuk" + "')";
                conexion.Open();
                comando.ExecuteNonQuery();
                return true;
            }

            catch (SqlException e)
            {
                throw e;
            }

            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        #endregion        
    }
}
