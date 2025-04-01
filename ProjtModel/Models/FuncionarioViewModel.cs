using Microsoft.AspNetCore.Mvc.Rendering;
namespace ProjtModel.Models
{
    public class FuncionarioViewModel
    {
        public int IdFuncionario { get; set; }

        public string Nome { get; set; }

        public int IdCargo { get; set; }

        public List<SelectListItem> ListaCargos { get; set; }

    }
}
