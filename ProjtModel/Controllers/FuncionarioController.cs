using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjtModel.Classes;
using ProjtModel.Models;
using System.Data;

namespace ProjtModel.Controllers
{
    public class FuncionarioController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult ExibirFuncionario()
        {
            FuncionarioViewModel o_FuncionarioVM = new FuncionarioViewModel();

            Cargo o_Cargo = new Cargo();

            DataTable tabCargo = o_Cargo.ObterCargo();

            o_FuncionarioVM.ListaCargos = (from DataRow dr in tabCargo.Rows
                                           select new SelectListItem()
                                           {
                                               Value = dr["IdCargo"].ToString(),
                                               Text = dr["Nome"].ToString(),
                                           }).ToList();


            return View("ExibirFuncionarioView", o_FuncionarioVM);
        }

        public IActionResult ProcessarFuncionario(FuncionarioViewModel o_FuncionarioVM)
        {
            string exibir = "";

            exibir += "Nome do Funcionario: " + o_FuncionarioVM.Nome + "\n";
            exibir += "ID do cargo: " + o_FuncionarioVM.IdCargo + "\n";           

            return Content(exibir);
        }
    }
}
