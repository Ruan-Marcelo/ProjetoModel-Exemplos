using Microsoft.AspNetCore.Mvc;
using ProjtModel.Models;

namespace ProjtModel.Controllers
{
    public class InscricaoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult ExibirInscricao()
        {
            return View("ExibirInscricaoView");
        }
        public IActionResult ProcessarInscricao(InscricaoViewModel o_InscricaoVM)
        {
            return View();
        }
    }
}
