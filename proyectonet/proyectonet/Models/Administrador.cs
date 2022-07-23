using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace proyectonet.Models


{
    public class Administrador
    {
        public int administrador_id { get; set; }
        public string? administrador_nombre { get; set; }

        public string? administrador_correo { get; set; }
    }
}
