using Microsoft.AspNetCore.Mvc;
using ProjtModel.Models;

namespace ProjtModel.Controllers
{
    public class ProdutoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult ExibirProduto()
        {
            return View("ExibirProdutoView");
        }
        public IActionResult ProcessarProduto(ProdutoViewModel o_ProdutoVM)
        {
            try
            {
                //Se deu erro na validação
                if (!ModelState.IsValid)
                {
                    return View("ExibirProdutoView", o_ProdutoVM);
                }

                //Regras de negócio do sistema
                return Ok("Fim");
            }
            catch (Exception ex)
            {
                return Ok("Ocorreu um erro.");
            }



            return Ok("Fim");
        }
    }
}
