using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }
    

    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Nome do Lanche")]
    [MinLength(10, ErrorMessage = "Descrição deve conter no minimo {1} caracteres")]
    [MaxLength(80, ErrorMessage = "Descrição não deve exceder {1} caracteres")]
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
    [Required(ErrorMessage = "O preço deve ser informado")]
    [Display(Name = "Preço")]
    [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
    public decimal Preco { get; set; }


    [Display (Name = "caminho da imagem")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
    public string ImagemUrl { get; set; }


    [Display(Name = "caminho da imagem miniatura")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
    public string ImagemThumbnailUrl { get; set; }

    [Display(Name = "Preferido")]
    public bool IsLanchePreferido { get; set; }

    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }


    public int CategoriaId { get; set; } 
    public virtual Categoria Categoria { get; set; }

}

