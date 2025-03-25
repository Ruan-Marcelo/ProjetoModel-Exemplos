using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjtModel.Models
{
    public class ProdutoViewModel
    {
        [ValidateNever]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Informe o nome do Produto. ")]
        [StringLength(20, 
            ErrorMessage = "O nome deve ter entre 2 e 20 caracteres.", 
            MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Preço do Produto. ")]
        [Column(TypeName = "decimal(7, 2)")]
        [Range(100,
               2000, 
               ErrorMessage = "*Valor deve ser entre (R$ 100,00 -  2.000,00.)")]
        public Decimal Preco { get; set; }

        [MaxLength(100)]
        public string Observacao { get; set; }
    }
}
