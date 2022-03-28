using LanchesM.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesM.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _CategoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _CategoriaRepository = categoriaRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categorias = _CategoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}
