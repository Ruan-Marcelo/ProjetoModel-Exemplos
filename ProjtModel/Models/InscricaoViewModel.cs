namespace ProjtModel.Models
{
    public class InscricaoViewModel
    {
        //input text
        public string Nome { get; set; }

        //Select
        public string EstadoCivil { get; set; }

        //Check Box
        public bool EnsinoFundamental { get; set; }
        public bool EnsinoMedio { get; set; }
        public bool EnsinoSuperior { get; set; }

        //Radio
        public string TipoSanguineo { get; set; }
    }
}
