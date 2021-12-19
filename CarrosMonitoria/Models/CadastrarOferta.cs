using System.ComponentModel.DataAnnotations;

namespace CarrosMonitoria.Models
{
    public class CadastrarOferta
    {
        [Key]
        public int Id_Oferta { get; set; }
        public string NomeCarro { get; set; }
        public string Preco { get; set; }
    }
}
