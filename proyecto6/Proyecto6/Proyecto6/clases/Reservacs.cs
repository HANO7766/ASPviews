using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.clases
{
    internal class Reservacs
    {

        private int reserva_id;
        private DateTime reserva_fecha;
        private String reserva_tipo;

        public int Reserva_id { get => reserva_id; set => reserva_id = value; }
        public DateTime Reserva_fecha { get => reserva_fecha; set => reserva_fecha = value; }
        public string Reserva_tipo { get => reserva_tipo; set => reserva_tipo = value; }

        public Reservacs()
        {
        }

        public Reservacs(int reserva_id, DateTime reserva_fecha, string reserva_tipo)
        {
            this.reserva_id = reserva_id;
            this.reserva_fecha = reserva_fecha;
            this.reserva_tipo = reserva_tipo;
        }
        public void reservas()
        {
            this.reserva_id = 1;
            this.reserva_tipo = "Corte de cabello";

            Console.WriteLine("el id del trabajador: " + this.reserva_id);
            Console.WriteLine("el rut del trabajador: " + this.reserva_tipo);

        }
    }
}
