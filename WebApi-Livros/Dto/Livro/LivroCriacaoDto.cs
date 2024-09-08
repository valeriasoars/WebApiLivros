using WebApi_Livros.Dto.Vinculo;
using WebApi_Livros.Models;

namespace WebApi_Livros.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
