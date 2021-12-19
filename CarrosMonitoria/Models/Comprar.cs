using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarrosMonitoria.Models
{
    public class Comprar
    {
        [Key]
        public int IdCompra { get; set; }
        public string Email { get; set; }
        [ForeignKey("CadastrarCarro")]
        public int Id_Carro { get; set; }
        public virtual CadastrarCarro CadastrarCarro { get; set; }
    }
}