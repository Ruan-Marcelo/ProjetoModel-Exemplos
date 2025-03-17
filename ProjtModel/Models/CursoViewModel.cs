using System.Data;

namespace ProjtModel.Models
  
{
    public class CursoViewModel
    {
        //Propriedades
        public int IdCurso { get; set; }

        public string Curso { get; set; }

        public DataTable Disciplinas { get; set; }

    }
}
