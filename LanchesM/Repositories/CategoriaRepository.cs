using LanchesM.Context;
using LanchesM.Models;
using LanchesM.Repositories.Interfaces;

namespace LanchesM.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
