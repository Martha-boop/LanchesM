using LanchesM.Repositories.Interfaces;
using LanchesM.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesM.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()

        {
           // ViewData["Titulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;


            // var lanches = _lancheRepository.Lanches;
            // var totalLanches = lanches.Count();

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);

           // ViewBag.Total = "Total de Lanches";
            //ViewBag.TotalLanches = totalLanches;
           // return View(lanches);
        }
    }
}
