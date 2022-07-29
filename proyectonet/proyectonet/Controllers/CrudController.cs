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
                Console.WriteLine("error al guardar" + exe.Message);
            }
            finally
            {
                conexionDB.Close();
            }

            return RedirectToAction("Index", "Crud");
        }
        public IActionResult borrar(int id)
        {
            string sql = "DELETE FROM productos WHERE id='" + id + "'";

            MySqlConnection conexionDB = Conexion.Connexion();
            conexionDB.Open();
            Console.WriteLine("Registro eliminado ");
            try
            {
                MySqlCommand cmd = new(sql, conexionDB);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exec)
            {
                Console.WriteLine("ERROR AL ELIMINAR " + exec.Message);
            }
            finally
            {
                conexionDB.Close();
            }

            return RedirectToAction("Index", "Crud");
        }

    }
}
