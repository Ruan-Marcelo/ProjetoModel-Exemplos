using System.Data;
namespace ProjtModel.Classes
{
    public class Cargo
    {
        public DataTable ObterCargo()
        {
            DataTable tabCargo = new DataTable();
            tabCargo.Columns.Add("IdCargo", typeof(int));
            tabCargo.Columns.Add("Nome", typeof(string));

            DataRow dtRow;

            dtRow = tabCargo.NewRow();
            dtRow["IdCargo"] = 1;
            dtRow["Nome"] = "Diretor";
            tabCargo.Rows.Add(dtRow);

            dtRow = tabCargo.NewRow();
            dtRow["IdCargo"] = 2;
            dtRow["Nome"] = "Gerente";
            tabCargo.Rows.Add(dtRow);

            dtRow = tabCargo.NewRow();
            dtRow["IdCargo"] = 3;
            dtRow["Nome"] = "Supervisor";
            tabCargo.Rows.Add(dtRow);

            dtRow = tabCargo.NewRow();
            dtRow["IdCargo"] = 4;
            dtRow["Nome"] = "Operador";
            tabCargo.Rows.Add(dtRow);

            return tabCargo;
        }




    }
}
