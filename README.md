# Descrição

Criando uma API mínima com o ASP.NET Core


## Conteúdos

- O novo template do ASP.NET
- Entity Framework Core
- Connection String
- Configurando o DbContext
- Lendo informações do SQLite
- Trabalhando com Migrations
- ViewModels
- Validações
- Swagger e Open API


## Sobre

APIs mínimas são uma abordagem simplificada para criar APIs de HTTP rápidas com o ASP.NET Core. Você pode criar pontos de extremidade REST totalmente funcionais com o mínimo de codificação e configuração. Declare fluentemente rotas e ações de API para ignorar o scaffolding tradicional e evitar controladores desnecessários.


## Requisitos

.NET SDK 7.0: Certifique-se de ter o .NET SDK 7.0 instalado para compilar e executar o projeto. Você pode baixá-lo em dotnet.microsoft.com.


## Instalação

1. **Clone o Repositório:**
    
    Abra o terminal ou prompt de comando e execute o seguinte comando para clonar o repositório:
    ```
    git clone https://github.com/denisprdo/ASP.NET-Minimal-APIs.git
    ```   
        
2. **Abra o Projeto no Visual Studio:**
    
    Abra o Visual Studio 2022 e selecione "Arquivo" > "Abrir" > "Projeto/Solução". Navegue até o diretório onde você clonou o repositório e abra o arquivo `.sln`.
    
3. **Restaure as Dependências:**
    
    No Visual Studio, clique com o botão direito no projeto da API no Gerenciador de Soluções e escolha "Restaurar Pacotes NuGet" para garantir que todas as dependências sejam restauradas.
    
4. **Configure a Conexão com o Banco de Dados:**
    
    Se o projeto estiver usando um banco de dados, verifique e configure a string de conexão no arquivo de configuração apropriado, como `appsettings.json`.
    
5. **Execute o Projeto:**
    
    Pressione `F5` ou clique em "Depurar" > "Iniciar Depuração" no Visual Studio para iniciar a API. O Visual Studio deve iniciar um servidor local e abrir a API no seu navegador padrão.
    
6. **Teste a API:**
    
    Abra uma ferramenta como Postman ou use uma solicitação HTTP para testar os endpoints da API. Os detalhes sobre os endpoints disponíveis e como usá-los devem ser documentados no próprio projeto.
    

Agora você tem a API Mínima em ASP.NET configurada e em execução no seu ambiente local. Certifique-se de consultar a documentação da API ou o README do projeto para obter informações detalhadas sobre como usar os endpoints disponíveis.