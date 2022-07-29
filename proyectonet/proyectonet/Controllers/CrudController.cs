using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using proyectonet.Models;

namespace proyectonet.Controllers
{
    public class CrudController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ingresar(int cod, String nombre, String descrip, int precio)
        {
            String sql = "INSERT INTO productos (id, nombre, descripcion, precio) VALUES ('" + cod + "', '" + nombre + "', '" + descrip + "', '" + precio + "')";

            MySqlConnection conexionDB = Conexion.Connexion();
            conexionDB.Open();
            try
            {
                MySqlCommand cmd = new(sql, conexionDB);
                cmd.ExecuteNonQuery();


            }
            catch (Exception exe)
            {
                Console.WriteLine("no se puede guardar" + exe.Message);
            }
            finally
            {
                conexionDB.Close();
            }

            return RedirectToAction("Index", "Crud");
        }

    }
}
