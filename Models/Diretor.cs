using AtividadeFilmes.Models;
namespace AtividadeFilmes.Models
{
    public class Diretor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public ICollection<Filme> Filmes { get; set; } = new List<Filme>();
    }
}