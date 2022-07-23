using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto6.clases
{
    internal class producto
    {
        private int producto_id;
        private String producto_nombre;
        private int producto_precio;
        private int stock;

        public int Producto_id { get => producto_id; set => producto_id = value; }
        public string Producto_nombre { get => producto_nombre; set => producto_nombre = value; }
        public int Producto_precio { get => producto_precio; set => producto_precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public producto()
        {
        }

        public producto(int producto_id, string producto_nombre, int producto_precio, int stock)
        {
            this.producto_id = producto_id;
            this.producto_nombre = producto_nombre;
            this.producto_precio = producto_precio;
            this.stock = stock;
        }
        public void Productos()
        {
            this.producto_id = 1;
            this.producto_nombre = "shampoo anti caspa";
            this.producto_precio = 12000;
            this.stock = 10;
            Console.WriteLine("el id del producto: " + this.producto_id);
            Console.WriteLine("el nombre del producto es : " + this.producto_nombre);
            Console.WriteLine("el el precio es: " + this.producto_precio);
            Console.WriteLine("la stock es: " + this.stock);
        }
    }
}
