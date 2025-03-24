namespace ProjtModel.Classes
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }

        public string Modelo { get; set; }

        public string FotoVeiculo { get; set; }

        public IFormFile Imagem { get; set; }
    }
}
