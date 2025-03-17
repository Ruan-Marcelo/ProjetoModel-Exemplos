using Microsoft.AspNetCore.Mvc;
using ProjtModel.Models;

namespace ProjtModel.Controllers
{
    public class UsuarioController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult ExibirImagem()
        {
            return View("ExibirImagemView");
        }

        public IActionResult ProcessarImagem(UsuarioViewModel o_UsuarioVM)
        {
            string diretorio;
            int idUsuario;
            string nome;

            idUsuario = o_UsuarioVM.IdUsuario;
            nome = o_UsuarioVM.Nome;

            //========================
            //Criação da pasta Usúario 
            //========================
            diretorio = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Usuario");

            //============================================================================================================================
            //Criação da pasta Usúario (!Inverte o resultado, caso seja false ele inverte e passa a ser true criando o diretorio e etc...)
            //============================================================================================================================
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }
            //===============
            //Dados da Imagem
            //===============
            FileInfo o_FileInfo = new FileInfo(o_UsuarioVM.Imagem.FileName);

            //====================================================================
            //Concatenando o nome do Usúario com Id do mesmo para não dar conflito
            //====================================================================
            string nomeArqFoto;
            nomeArqFoto = idUsuario.ToString() + o_FileInfo.Extension;

            //==============================
            // Caminho para salvar a imagem
            //==============================
            string fotoUsuario = Path.Combine(diretorio, nomeArqFoto);

            //=================================================
            //Faz o upload da imagem e grava na pasta informada
            //=================================================
            using (var stream = new FileStream(fotoUsuario, FileMode.Create))
            {
                o_UsuarioVM.Imagem.CopyTo(stream);
            }
       
            return Ok("Upload de imagem efetuada com sucesso!");
        }

        public IActionResult ExibirUsuario()
        {
            UsuarioViewModel o_UsuarioVM = new UsuarioViewModel();

            o_UsuarioVM.IdUsuario = 69;
            o_UsuarioVM.Nome = "Lucas Borges Silva";
            o_UsuarioVM.FotoUsuario = $"Usuario/{o_UsuarioVM.IdUsuario}.jfif";

            return View("ExibirUsuarioView", o_UsuarioVM);
        }

    }
}
