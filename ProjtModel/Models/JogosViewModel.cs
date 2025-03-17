namespace ProjtModel.Models
{
    public class JogosViewModel
    {
        //Porpriedades

        public int IdJogo { get; set; }

        public string Nome { get; set; }

        public string Genero { get; set; }

        public string Produtora { get; set; }

        public DateTime AnoLancamento { get; set; }

        public string NomePersonagemPrincipal { get; set; }

        public int IdadeMin { get; set; }

        public float ArmazenamentoMin { get; set; }

        public float HorasDeJogo { get; set; }

        public string NomePersonagemCoadjuvante { get; set; }


    }
}
