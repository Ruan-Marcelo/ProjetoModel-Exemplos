using Microsoft.AspNetCore.Mvc;
using ProjtModel.Models;

namespace ProjtModel.Controllers
{
    public class PessoaController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult ExibirPessoa()
        {
            PessoaViewModel o_PessoaVM = new PessoaViewModel();

            o_PessoaVM.IdPessoa = 100;
            o_PessoaVM.Nome = "Borges";
            o_PessoaVM.Email = "borgesxacau@gmail.com";
            o_PessoaVM.Departamento = "Privacy";

            return View("ExibirPessoaView", o_PessoaVM);
        }
        public IActionResult ExibirListaPessoa()
        {
            List<PessoaViewModel> o_ListPessoaViewModel = new List<PessoaViewModel>();

            PessoaViewModel o_PessoaVM;

            o_PessoaVM = new PessoaViewModel();
            o_PessoaVM.IdPessoa = 100;
            o_PessoaVM.Nome = "Borges";
            o_PessoaVM.Email = "borgesxacau@gmail.com";
            o_PessoaVM.Departamento = "Privacy";
            o_ListPessoaViewModel.Add(o_PessoaVM);

            o_PessoaVM = new PessoaViewModel();
            o_PessoaVM.IdPessoa = 200;
            o_PessoaVM.Nome = "Japa";
            o_PessoaVM.Email = "japau@gmail.com";
            o_PessoaVM.Departamento = "onlyfans";
            o_ListPessoaViewModel.Add(o_PessoaVM);

            o_PessoaVM = new PessoaViewModel();
            o_PessoaVM.IdPessoa = 100;
            o_PessoaVM.Nome = "Ruan";
            o_PessoaVM.Email = "ruanxacau@gmail.com";
            o_PessoaVM.Departamento = "erome";
            o_ListPessoaViewModel.Add(o_PessoaVM);

            return View("ExibirListaPessoaView", o_ListPessoaViewModel);
        }

        public IActionResult ExibirCafeteria()
        {
            List<CafeteriaViewModel> o_ListCafeteriaViewModel = new List<CafeteriaViewModel>();

            CafeteriaViewModel o_Cafeteria;

            o_Cafeteria = new CafeteriaViewModel();
            o_Cafeteria.Id = 1;
            o_Cafeteria.Nome = "Pingado";
            o_Cafeteria.Descricao = "Café com leite";
            o_Cafeteria.Preco = 7.00f;
            o_ListCafeteriaViewModel.Add(o_Cafeteria);

            o_Cafeteria = new CafeteriaViewModel();
            o_Cafeteria.Id = 2;
            o_Cafeteria.Nome = "Três Corações";
            o_Cafeteria.Descricao = "Café com chantily";
            o_Cafeteria.Preco = 12.00f;
            o_ListCafeteriaViewModel.Add(o_Cafeteria);

            o_Cafeteria = new CafeteriaViewModel();
            o_Cafeteria.Id = 3;
            o_Cafeteria.Nome = "Capuccino";
            o_Cafeteria.Descricao = "Leite em pó e chocolate";
            o_Cafeteria.Preco = 15.00f;
            o_ListCafeteriaViewModel.Add(o_Cafeteria);


            return View("ExibirCafeteriaView" , o_ListCafeteriaViewModel);
        }

    }
}
