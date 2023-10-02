using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }
    
    [Required(ErrorMessage = "O nome d lanche deve ser informado")]
    [Display(Name = "Nome do Lanche")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
    [Display(Name = "Descrição do lanche")]
    [MinLength(20, ErrorMessage = "Descrição deve conter no minimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição não deve exceder {1} caracteres")]
    public string DescricaoCurta { get; set;}

    public string DescricaoDetalhada { get; set; }

    [NotMapped]
    public DateTime DataDeCriacao {get; set;}

    [Precision(10,2)]
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public string ImagemThumbnailUrl { get; set; }
    public string IsLanchePreferido { get; set; }
    public bool EmEstoque { get; set; }


    public int CategoriaId { get; set; } 
    public virtual Categoria Categoria { get; set; }

}

