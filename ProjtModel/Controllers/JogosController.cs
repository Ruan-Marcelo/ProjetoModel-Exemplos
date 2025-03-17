using Microsoft.AspNetCore.Mvc;
using ProjtModel.Models;

namespace ProjtModel.Controllers
{
    public class JogosController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult ExibirJogo()
        {
            JogosViewModel o_JogosVM = new JogosViewModel();

            o_JogosVM.IdJogo = 1;
            o_JogosVM.Nome = "GOD OF WAR RAGNAROK";
            o_JogosVM.Genero = "Acão";
            o_JogosVM.Produtora = "Sony";
            o_JogosVM.AnoLancamento = DateTime.Now;
            o_JogosVM.NomePersonagemPrincipal = "Kratos";
            o_JogosVM.NomePersonagemCoadjuvante = "Atreus";
            o_JogosVM.IdadeMin = 18;
            o_JogosVM.ArmazenamentoMin = 120.50f;
            o_JogosVM.HorasDeJogo = 20.3f;

            return View("ExibirJogoView", o_JogosVM);
        }
    }
}
