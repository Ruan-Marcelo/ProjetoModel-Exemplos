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
                //--------------------------------------
                //Regras de negócio do sistema (Aqui)  |
                //--------------------------------------

                //Simulação de erro
                //throw new Exception("Ocorreu um erro no banco de dados.");


                TempData["MsgSucesso"] = "Produto cadastrado com sucesso!";
                return RedirectToAction("ExibirProduto");
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = $"Erro: {ex.Message}!";
                return View("ExibirProdutoView", o_ProdutoVM);
            }
        }
    }
}
