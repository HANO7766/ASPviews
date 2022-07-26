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

    public class AdministradorContext : DbContext
    {
        public DbSet<Administrador> Administrador { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;database=scripttaller;user=root;password=;");
        }
    }
}
