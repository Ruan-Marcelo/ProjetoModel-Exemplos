## ExibirImagemView.cshtml

A página `ExibirImagemView.cshtml` é responsável por exibir um formulário para upload de imagens de usuários. Esta página faz parte do projeto Razor Pages e utiliza o modelo `UsuarioViewModel` para capturar os dados do usuário. Abaixo estão os principais elementos e funcionalidades desta página:

### Funcionalidades

- **ID Usuário**: Um campo de entrada numérico para o ID do usuário.
- **Nome**: Um campo de entrada de texto para o nome do usuário.
- **Imagem**: Um campo de entrada para upload de arquivos, permitindo que o usuário selecione uma imagem para upload.

### Integração

- O formulário é enviado para a ação `ProcessarImagem` no controlador `Usuario`.
- O formulário utiliza `enctype="multipart/form-data"` para permitir o upload de arquivos.

### Exemplo de Uso

Ao acessar a página `ExibirImagemView`, o usuário pode preencher os campos de ID, Nome e selecionar uma imagem para upload. Após preencher o formulário, o usuário pode clicar no botão "Enviar Informações" para submeter os dados.

### Código


Essa descrição fornece uma visão geral clara da funcionalidade da página `ExibirImagemView.cshtml` e como ela se encaixa no projeto.

