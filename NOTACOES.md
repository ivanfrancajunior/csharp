## Código gerenciado:

## Tipos de Projeto

- Class Library

  - O projeto final é uma DLL e não possui interface

- Console Aplication

  - O resultado é uuma aplicação que roda no terminal
  - pode receber dados, espera inputs do usuário pra seguir a lógica da aplicação

- Projetos Web
  \*\* Projetos web

        - ASP.NET Web
        - ASP.NET MVC
        - ASP.NET API

  \*\* projetos Testes

        - Microsoft Tests(projeos de testes para a aplicação)

- Class Library

# C# FUNDAMENTOS

### Namespace

    * Os namespaces em C# são usados para organizar e agrupar tipos, classes, estruturas, interfaces e outros elementos em um projeto.

    * Eles ajudam a evitar conflitos de nomes e tornam o código mais organizado e legível.

### Exp:

```c#
// ./test/meuapp.cs
namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testandoo";
            Console.WriteLine(texto);
        }
    }
}


// ./teste/app/meuapp.cs --- NÃO PODE!

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testandoo";
            Console.WriteLine(texto);
        }
    }
}

```

### 'using'

    * As diretivas using no início de um arquivo C# são usadas para importar namespaces.

    * Isso permite que você use tipos definidos nesses namespaces sem precisar especificar o nome completo toda vez.

### Exp:

```c#

using System; // Importa o namespace System

class MinhaClasse
{
    void Exemplo()
    {
        Console.WriteLine("Olá, mundo!"); // Pode usar Console em vez de System.Console
    }
}

```

### Variaveis e Constantes

    São estruturas utilizadas para armazenar informações.

**variaveis**

    Variaves podem ser alterados;

    não precisam ser iniciadas com valor;

**constantes**

    Constantes não sofrem alterações.

    Usadas sempre em maiusculo;

    Devem ser iniciadas assim que declaradas, caso não sejam recebem o valor default do seu tipo;

### Tipos PRIMITIVOS:

```c#

class TiposPrimitivos
{
    // Atributos para cada tipo de dado primitivo

    // Inteiros
    int inteiro = 42;
    uint inteiroSemSinal = 12345;

    // Ponto Flutuante
    float pontoFlutuante = 3.14f;
    double pontoFlutuanteDuplaPrecisao = 3.1415926579;
    decimal decimalAltaPrecisao = 12345.6789m;

    // Booleanos
    bool verdadeiro = true;
    bool falso = false;

    // Caracteres
    char caractere = 'A';

    // Bytes
    byte valorByte = 255;
    sbyte valorSByte = -128;

    // Inteiros de Tamanho Fixo
    short inteiroCurto = 1000;
    ushort inteiroCurtoSemSinal = 2000;
    long inteiroLongo = 1234567890;
    ulong inteiroLongoSemSinal = 9876543210;

    //Object(Famoso any do TS)
    object any = 'qualquer valor assinalado'

    // Construtor vazio
    public TiposPrimitivos()
    {
        // Nada a fazer no construtor
    }

    // Métodos (se necessário)
}
```
### Nullable Types
```c#
    class ExemploNullable
{
    // Nullable types
    int? numeroInteiroNullable = null; // Pode conter um valor inteiro ou ser nulo
    double? numeroDuploNullable = 3.14; // Pode conter um valor de ponto flutuante ou ser nulo
    bool? booleanoNullable = true; // Pode conter um valor booleano ou ser nulo

    // Método que retorna void (sem valor de retorno)
    public void MetodoVoid()
    {
        // Este método não retorna um valor
        Console.WriteLine("Método void executado.");
    }

    public ExemploNullable()
    {
        // Exemplo de uso de tipos anuláveis
        if (numeroInteiroNullable.HasValue)
        {
            Console.WriteLine("Valor inteiro: " + numeroInteiroNullable.Value);
        }
        else
        {
            Console.WriteLine("Valor inteiro é nulo.");
        }

        if (numeroDuploNullable.HasValue)
        {
            Console.WriteLine("Valor de ponto flutuante: " + numeroDuploNullable.Value);
        }
        else
        {
            Console.WriteLine("Valor de ponto flutuante é nulo.");
        }

        if (booleanoNullable.HasValue)
        {
            Console.WriteLine("Valor booleano: " + booleanoNullable.Value);
        }
        else
        {
            Console.WriteLine("Valor booleano é nulo.");
        }

        // Chamando o método void
        MetodoVoid();
    }
}


```