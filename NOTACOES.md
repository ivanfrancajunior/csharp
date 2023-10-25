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

## Variaveis e Constantes

    São estruturas utilizadas para armazenar informações.

**variaveis**

    Variaves podem ser alterados;

    não precisam ser iniciadas com valor;

**constantes**

    Constantes não sofrem alterações.

    Usadas sempre em maiusculo;

    Devem ser iniciadas assim que declaradas, caso não sejam recebem o valor default do seu tipo;

## Tipos PRIMITIVOS:

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

### Valores padrões

```c#
class ValoresPadrao
{
    // Tipos de dados com valores padrão
    int valorPadraoInteiro;
    double valorPadraoDouble;
    bool valorPadraoBooleano;
    char valorPadraoCaractere;
    byte valorPadraoByte;
    string valorPadraoString;

    // Construtor que inicializa os atributos
    public ValoresPadrao()
    {
        // Os valores padrão são atribuídos automaticamente

        // int -> 0 (valor padrão)
        valorPadraoInteiro = 0;

        // double -> 0.0 (valor padrão)
        valorPadraoDouble = 0.0;

        // bool -> false (valor padrão)
        valorPadraoBooleano = false;

        // char -> '\0' (caractere nulo, valor padrão)
        valorPadraoCaractere = '\0';

        // byte -> 0 (valor padrão)
        valorPadraoByte = 0;

        // string -> null (valor padrão)
        valorPadraoString = null;
    }

    // Métodos (se necessário)
}
```

<hr>

# Conversão de tipos

### **Conversão implicita**

```c#
// Conversão implícita de int para double
int inteiro = 42;
double numeroDecimal = inteiro;

// Isso imprimirá 42.0
Console.WriteLine(numeroDecimal);

```

### **Conversão explicita**

```c#
double numeroDecimal = 3.14;

// Conversão explícita de double para int
int inteiro = (int)numeroDecimal;

// Isso imprimirá 3
Console.WriteLine(inteiro);

```

<hr>

### Conversão usando Parse e Convert:

**Parse:**

- O método Parse é geralmente usado para converter uma representação de texto (como uma string) em um tipo de valor específico, como int, double, bool, etc.

- Ele lança exceções, como FormatException, se a conversão não for possível devido a uma formatação inválida.

```c#

string numeroTexto = "42";
int numeroInteiro = int.Parse(numeroTexto);

```

**Convert:**

- O método Convert é usado para converter valores entre tipos diferentes, mas principalmente entre tipos numéricos, como int, double, float, etc.

- Ele também lida com conversões de tipos de forma segura, mas não lança exceções de formato. Em vez disso, retorna o valor padrão do tipo, se a conversão não for bem-sucedida.

```c#

string numeroTexto = "3.14";
double numeroDuplo = Convert.ToDouble(numeroTexto);

```

### Operadores:

**Aritiméticos**

- Adição: Realiza a adição de dois valores.

* Subtração: Realiza a subtração de dois valores.

- Multiplicação: Realiza a multiplicação de dois valores.

* Divisão: Realiza a divisão de um valor pelo outro.

* Módulo: Retorna o resto da divisão entre dois valores.

```c#

int a = 5;
int b = 3;
int resultado = a + b; // resultado é 8

```

**Atribuição**

- = Atribuição: Atribui um valor a uma variável.

- += Adição composta: Adiciona o valor à variável e atribui o resultado.

- -= Subtração composta: Subtrai o valor da variável e atribui o resultado.

- \*= Multiplicação composta: Multiplica o valor da variável e atribui o resultado.

- /= Divisão composta: Divide o valor da variável e atribui o resultado.

```c#

int x = 5;
x += 3; // x agora é 8

```

**Comparação**

- == (Igual): Verifica se dois valores são iguais.

- != (Diferente): Verifica se dois valores são diferentes.

- < (Menor que): Verifica se o valor da esquerda é menor que o da direita.

  _-_ > (Maior que): Verifica se o valor da esquerda é maior que o da direita.

  _-_ <= (Menor ou igual a): Verifica se o valor da esquerda é menor ou igual ao da direita.

  _-_ >= (Maior ou igual a): Verifica se o valor da esquerda é maior ou igual ao da direita.

```c#
int numeroA = 5;
int numeroB = 3;
bool igual = (numeroA == numeroB); // igual é false
bool diferente = (numeroA !== numeroB); // igual é true
bool maior = (numeroA > numeroB); // igual é true
bool menor = (numeroA < numeroB); // igual é false

```

**Lógicos**

- && (E lógico): Retorna verdadeiro se ambas as expressões forem verdadeiras.

- || (OU lógico): Retorna verdadeiro se pelo menos uma das expressões for verdadeira.

- ! (Negação lógica): Inverte o valor de uma expressão lógica.

```c#

bool condicao1 = true;
bool condicao2 = false;
bool resultado = condicao1 && condicao2; // resultado é false

```

**Condicionais**

- As instruções **if** e **else if** são usadas para criar condicionais em seu código, permitindo que você execute diferentes blocos de código com base em condições lógicas.

- A instrução **switch** é usada para criar uma estrutura de controle de fluxo que permite escolher entre várias opções com base no valor de uma expressão. Ela é frequentemente usada quando você tem várias condições a serem verificadas em relação a uma única variável.

```c#

//if e else if

int nota = 80;

if (nota >= 90)
{
    Console.WriteLine("Aprovado com nota A.");
}
else if (nota >= 80)
{
    Console.WriteLine("Aprovado com nota B.");
}
else if (nota >= 70)
{
    Console.WriteLine("Aprovado com nota C.");
}
else
{
    Console.WriteLine("Reprovado.");
}


//switch

int diaDaSemana = 3;

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Segunda-feira");
        break;
    case 2:
        Console.WriteLine("Terça-feira");
        break;
    case 3:
        Console.WriteLine("Quarta-feira");
        break;
    case 4:
        Console.WriteLine("Quinta-feira");
        break;
    case 5:
        Console.WriteLine("Sexta-feira");
        break;
    case 6:
    case 7:
        Console.WriteLine("Fim de semana");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}

```

### Laços de repetição

**for**
 * O laço **for** é usado quando você sabe exatamente quantas vezes deseja repetir um bloco de código. É composto por três partes: uma inicialização, uma condição e uma expressão de atualização. O bloco de código é repetido enquanto a condição for verdadeira.

```c#
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

**while**

 * O laço **while** é usado quando você deseja repetir um bloco de código enquanto uma condição específica for verdadeira. A condição é verificada no início do laço.

```c#
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

**do while**

 * O laço **do-while** é semelhante ao while, mas a condição é verificada no final do bloco de código. Isso garante que o bloco de código seja executado pelo menos uma vez, mesmo se a condição for falsa desde o início.


```c#
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);
```

### Metodos e Funções:

```c#

    class MinhaClasse
{
    // Método simples sem parâmetros e sem retorno
    public void MetodoSemRetorno()
    {
        // Código para realizar uma tarefa
    }

    // Método com parâmetros e retorno
    public int MetodoComRetorno(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }
}


```