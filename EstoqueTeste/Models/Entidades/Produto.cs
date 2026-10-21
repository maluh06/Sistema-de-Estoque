using EstoqueTeste.Models.Enuns;
using System.ComponentModel.DataAnnotations;

namespace EstoqueTeste.Models.Entidades
{
    public class Produto
    {
        [Required]
        public string nome { get; set; }

        [Required]
        public double precoCusto { get; set; }

        [Required]
        public int quantidade { get; set; }

        [Required]
        public Fornecedor fornecedor { get; set; }

        [Required]
        public Categorias categoria { get; set; }

        [Required]
        public double precoVenda { get; set; }

        [Required]
        public int estoqueMinimo { get; set; }

        [Required]
        public DateTime primeiraEntrada{ get; set; } = DateTime.Now;

        public DateTime? ultimaEntrada { get; set; }

        [Required]
        [Key]
        public int id { get; set; }

    }
}
