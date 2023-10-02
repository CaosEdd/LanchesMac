using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models;

public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }
    public string CategoriaNome { get; set; }
    public string Descricao { get; set; }


    public List<Lanche> Lanches { get; set; }
}

