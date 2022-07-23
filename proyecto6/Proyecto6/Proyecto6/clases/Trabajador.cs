using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.clases
{
     class Trabajador
    {
        private int trabajador_id;
        private float trabajador_rut;
        private String trabajador_nombre;
        private String trabajador_contraseña;

        public int Trabajador_id { get => trabajador_id; set => trabajador_id = value; }
        public float Trabajador_rut { get => trabajador_rut; set => trabajador_rut = value; }
        public string Trabajador_nombre { get => trabajador_nombre; set => trabajador_nombre = value; }
        public string Trabajador_contraseña { get => trabajador_contraseña; set => trabajador_contraseña = value; }

        public Trabajador()
        {
        }

        public Trabajador(int trabajador_id, float trabajador_rut, string trabajador_nombre, string trabajador_contraseña)
        {
            this.trabajador_id = trabajador_id;
            this.trabajador_rut = trabajador_rut;
            this.trabajador_nombre = trabajador_nombre;
            this.trabajador_contraseña = trabajador_contraseña;
        }

        public void TrabajadorAtributos()
        {
            this.trabajador_id = 1;
            this.trabajador_rut = 25541191;
            this.trabajador_nombre = "renato";
            this.trabajador_contraseña = "osopanda";
            Console.WriteLine("el id del trabajador: " + this.trabajador_id);
            Console.WriteLine("el rut del trabajador: " + this.trabajador_rut);
            Console.WriteLine("el nombre del trabajador: " + this.trabajador_nombre);
            Console.WriteLine("la contraseña del trabajador: " + this.trabajador_contraseña);
        }
    }
}
