# KoguiApp

KoguiApp é uma aplicação móvel desenvolvida em **.NET MAUI** que demonstra manipulação de cores, geração de figuras a partir de matrizes e exibição de informações em cartões (Cards).  

---

## Funcionalidades

1. **Seção 1 - Lista de Itens**  
   - Exibe uma lista de itens com seus componentes e cores correspondentes.  
   - Cada item é apresentado em um card com nome, hexadecimal e componente.

2. **Seção 2 - Cores e Frase**  
   - Consulta a API [The Color API](https://www.thecolorapi.com/) para obter o **nome das cores** a partir de valores hexadecimais.  
   - Exibe cada cor em um card com nome e hexadecimal.  
   - Abaixo dos cards, uma frase é formada a partir dos componentes de cada cor.

3. **Seção 3 - Figura gerada a partir de matriz**  
   - Constrói uma figura a partir de uma matriz numérica.  
   - Pares são exibidos como branco e ímpares como preto.  
   - Mostra o nome do objeto gerado abaixo da figura.

---

## Paleta de cores da interface

- `#F35DA3`  
- `#0A0730`  
- `#3B1476`  
- `#322DA5`  
- `#FFFFFF`  

---

## Tecnologias Utilizadas

- [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/overview/)  
- [SkiaSharp](https://github.com/mono/SkiaSharp) para renderização de imagens  
- [The Color API](https://www.thecolorapi.com/) para obtenção de nomes de cores

---

## Estrutura do Projeto

```

KoguiApp/
│
├─ Models/         # Classes de modelo (CorItem, ChaveCor, etc.)
├─ Services/       # Serviços como ColorService
├─ App.xaml        # Definições globais da aplicação
├─ App.xaml.cs     # Inicialização da aplicação
└─ MainPage.xaml   # Layout principal

````

---

## Como Rodar

1. Clone o repositório:
```bash
git clone <URL_DO_REPOSITORIO>
````

2. Abra o projeto no **Visual Studio 2022/2025** com suporte a **.NET MAUI**.

3. Restaure os pacotes NuGet:

```bash
dotnet restore
```

4. Execute a aplicação em **Android**, **iOS**, **Windows** ou **Mac Catalyst**:

```bash
dotnet build -t:Run -f net8.0-android
```

---

## Observações

* Certifique-se de manter a **estrutura da matriz** com quebras de linha e espaços conforme o arquivo de entrada.
* O espaçamento entre os cards é feito usando `Margin` nos `Frame` dentro do `CollectionView`.
* Para alterar cores ou frases, atualize os arquivos em **Models** e **Services**.

---

## Contato

Desenvolvedor: **Fabricio**
Email: `fabriciobc47@gmail.com`
Projeto feito como parte de estudo em .NET MAUI e manipulação de gráficos com SkiaSharp.

