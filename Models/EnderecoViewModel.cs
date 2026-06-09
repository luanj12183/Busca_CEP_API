 using System.ComponentModel.DataAnnotations;
 
 namespace Busca_CEP_API.Models;

public class EnderecoViewModel
{
    [Required(ErrorMessage = "O CEP é obrigatório.")]
    public string Cep { get; set; }

    [Required(ErrorMessage = "O logradouro é obrigatório.")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "O bairro é obrigatório.")]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "A cidade é obrigatória.")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "O UF é obrigatório.")]
    public string Uf { get; set; }

    public string? Numero { get; set; }
}
