using System.ComponentModel.DataAnnotations;

namespace CarrosMonitoria.Models
{
    public class Contato
    {
        [Key]
        public int Id_Contato { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
    }
}
