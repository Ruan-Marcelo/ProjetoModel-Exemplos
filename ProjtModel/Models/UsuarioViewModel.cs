﻿namespace ProjtModel.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string FotoUsuario { get; set; }

        public IFormFile Imagem { get; set; }
    }
}
