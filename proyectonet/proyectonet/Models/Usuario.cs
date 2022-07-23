namespace proyectonet.Models
{
    public class Usuario
    {
        public int usuario_id { get; set; }
        public String? usuario_contraseña { get; set; }
        public Boolean usuario_estadocuenta { get; set; }
        public DateTime usuario_fecharegistro { get; set; }
    }
}
