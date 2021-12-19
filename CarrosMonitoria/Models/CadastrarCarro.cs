using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarrosMonitoria.Models
{
    public class CadastrarCarro
    {
        [Key]
        public int Id_Carro { get; set; }
        public string Nome_Carro { get; set; }
        public string Preco { get; set; }
        public int Ano { get; set; }
        public virtual List<Comprar> Comprar { get; set; }
    }
}
