
using MySql.Data.MySqlClient;

namespace proyectonet.Models
{
    public class Conexion
    {
        public static MySqlConnection Connexion()
        {
            String bd = "scripttaller";
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "";

            String cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; port=" + puerto + "; User Id=" + usuario + "; Password=" + password;

            try
            {
                MySqlConnection conexionBD = new(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return null;
            }

        }

    }
}
