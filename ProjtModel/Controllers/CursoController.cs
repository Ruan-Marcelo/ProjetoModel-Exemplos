using System.Data;
using Microsoft.AspNetCore.Mvc;
using ProjtModel.Models;

namespace ProjModel1.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult ExibirCurso()
        {
            //=============================================================
            //tabela
            //=============================================================

            DataTable o_tabDisciplina = new DataTable();
            o_tabDisciplina.Columns.Add("IdDisciplina", typeof(int));
            o_tabDisciplina.Columns.Add("NomeDisciplina", typeof(string));
            o_tabDisciplina.Columns.Add("Professor", typeof(string));

            DataRow o_DataRow;

            o_DataRow = o_tabDisciplina.NewRow();
            o_DataRow["IdDisciplina"] = 10;
            o_DataRow["NomeDisciplina"] = "Back-End";
            o_DataRow["Professor"] = "Lucas";
            o_tabDisciplina.Rows.Add(o_DataRow);

            o_DataRow = o_tabDisciplina.NewRow();
            o_DataRow["IdDisciplina"] = 20;
            o_DataRow["NomeDisciplina"] = "Front-End";
            o_DataRow["Professor"] = "Ruan";
            o_tabDisciplina.Rows.Add(o_DataRow);

            o_DataRow = o_tabDisciplina.NewRow();
            o_DataRow["IdDisciplina"] = 30;
            o_DataRow["NomeDisciplina"] = "Dart";
            o_DataRow["Professor"] = "Luiz";
            o_tabDisciplina.Rows.Add(o_DataRow);

            //=============================================================

            CursoViewModel o_CursoVM = new CursoViewModel();

            o_CursoVM.IdCurso = 100;
            o_CursoVM.Curso = "DESV";
            o_CursoVM.Disciplinas = o_tabDisciplina;


            return View("ExibirCursoView", o_CursoVM);
        }
    }
}
