# DotNetOllama

Um cliente de console .NET para interagir com o Ollama, permitindo conversas com modelos de linguagem de forma local.

## 📋 Descrição

DotNetOllama é uma aplicação de console desenvolvida em .NET 9.0 que utiliza a biblioteca [OllamaSharp](https://github.com/awaescher/OllamaSharp) para se comunicar com o servidor Ollama. A aplicação permite enviar prompts e receber respostas de modelos de linguagem configurados localmente.

## 🔧 Pré-requisitos

Antes de executar o projeto, certifique-se de ter instalado:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) ou superior
- [Ollama](https://ollama.ai/) instalado e em execução
- Modelo `phi3` baixado no Ollama (ou altere o modelo no código)

### Instalando o Ollama e o modelo phi3

1. Instale o Ollama seguindo as instruções em [ollama.ai](https://ollama.ai/)
2. Baixe o modelo phi3:
   ```bash
   ollama pull phi3
   ```
3. Verifique se o Ollama está rodando:
   ```bash
   ollama list
   ```

## 🚀 Instalação

1. Clone o repositório:
   ```bash
   git clone https://github.com/ddouglss/DotNetOllama.git
   cd DotNetOllama
   ```

2. Restaure as dependências:
   ```bash
   dotnet restore
   ```

## 💻 Como Usar

1. Certifique-se de que o Ollama está rodando (padrão na porta 11434):
   ```bash
   ollama serve
   ```

2. Execute a aplicação:
   ```bash
   dotnet run --project Ollama
   ```

3. Digite seu prompt e pressione Enter para receber a resposta do modelo.

## 🏗️ Build

Para compilar o projeto:

```bash
dotnet build
```

Para compilar em modo Release:

```bash
dotnet build --configuration Release
```

## 📦 Dependências

- **OllamaSharp** (v5.4.8) - Cliente .NET para a API do Ollama

## ⚙️ Configuração

A aplicação está configurada para:
- **URL do Ollama**: `http://localhost:11434`
- **Modelo padrão**: `phi3`

Para alterar essas configurações, edite o arquivo `Program.cs`:

```csharp
var url = new Uri("http://localhost:11434"); // Altere a URL se necessário
client.SelectedModel = "phi3"; // Altere o modelo conforme necessário
```

## 📝 Estrutura do Projeto

```
DotNetOllama/
├── Ollama/
│   ├── Ollama.csproj    # Arquivo de projeto
│   └── Program.cs       # Código principal da aplicação
├── DotNetOllama.sln     # Arquivo de solução
└── README.md            # Este arquivo
```

## 🤝 Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para:
- Reportar bugs
- Sugerir novas funcionalidades
- Enviar pull requests

## 📄 Licença

Este projeto está disponível como código aberto para uso pessoal e educacional.

## 🔗 Links Úteis

- [Ollama](https://ollama.ai/)
- [OllamaSharp no GitHub](https://github.com/awaescher/OllamaSharp)
- [.NET 9.0 Documentation](https://learn.microsoft.com/dotnet/)
