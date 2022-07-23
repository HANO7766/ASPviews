using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.clases
{
    public class Administrador
    {
        private String administrador_nombre;
        private String administrador_correo;

        public string Administrador_nombre { get => administrador_nombre; set => administrador_nombre = value; }
        public string Administrador_correo { get => administrador_correo; set => administrador_correo = value; }

        public Administrador()
        {
        }

        public Administrador(string administrador_nombre, string administrador_correo)
        {
            this.administrador_nombre = administrador_nombre;
            this.administrador_correo = administrador_correo;
        }
        public void AdministradorAtributos()
        {
            this.administrador_nombre = "Renato Torres";
            this.administrador_correo = "admin@gmail.com";
            Console.WriteLine("el nombre del administrador es: " + this.administrador_nombre);
            Console.WriteLine("el correo del administrador es: " + this.administrador_correo);
        }
    }

}
