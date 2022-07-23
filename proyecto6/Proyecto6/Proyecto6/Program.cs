using System;

namespace Proyecto6.clases{ 
public class Program
{
	public static void Main()
	{
	  
		Trabajador trabajador1= new Trabajador();
			trabajador1.TrabajadorAtributos();
			Console.WriteLine("===============");
			Usuario usuario1= new Usuario();
			usuario1.UsuarioRegistro();
			Console.WriteLine("===============");
			Reservacs reservas = new Reservacs();
			reservas.reservas();
			Console.WriteLine("===============");
			producto producto = new producto();
			producto.Productos();
			Console.WriteLine("===============");
			Cliente cliente1 = new Cliente();
			cliente1.ClienteAtributos();
			Console.WriteLine("===============");
			Carritocs carrito1 = new Carritocs();
			carrito1.carritoProducto();
			Console.WriteLine("===============");
			Administrador administrador1 = new Administrador();
			administrador1.AdministradorAtributos();
		}

	}

}