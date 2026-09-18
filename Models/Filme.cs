using AtividadeFilmes.Models;
namespace AtividadeFilmes.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int AnoLancamento { get; set; }
        public int DuracaoMinutos { get; set; }

        public int DiretorId { get; set; }
        public Diretor? Diretor { get; set; }

        public ICollection<Genero> Generos { get; set; } = new List<Genero>();
    }
}