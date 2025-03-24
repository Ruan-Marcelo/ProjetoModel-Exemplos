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
            string exibir = "";

            //Text
            exibir += "Nome:" + o_InscricaoVM.Nome + "\n";

            //Select
            exibir += "Estado Civil:" + o_InscricaoVM.EstadoCivil + "\n";

            //Chack Box
            exibir += "Ensino Fundamental:" + o_InscricaoVM.EnsinoFundamental + "\n";
            exibir += "Ensino Medio:" + o_InscricaoVM.EnsinoMedio + "\n";
            exibir += "Ensino Superior:" + o_InscricaoVM.EnsinoSuperior + "\n";

            //Radio
            exibir += "Tipo Sanguíneo:" + o_InscricaoVM.TipoSanguineo + "\n";

            return Content(exibir);
        }
    }
}
