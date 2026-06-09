cat <<'EOF'> Models/EnderecoViewModel.cs
namespace Busca_CEP_API.Models;

public class EnderecoViewModel
{
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Uf { get; set; }
    public string Numero { get; set; }
}
EOF 