using System;



namespace Calculator
{

    class Program
    {

        static void Main(string[] args)
        {


            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            int operacao = int.Parse(Console.ReadLine());


            switch (operacao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }




        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor");

            float valor1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());


            float soma = valor1 + valor2;
            Console.WriteLine($"O resultado é {soma}");
            Console.ReadKey();

            Menu();


        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor");

            float valor1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());


            float subtracao = valor1 - valor2;
            Console.WriteLine($"O resultado é {subtracao}");
            Console.ReadKey();

            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadKey();

            Menu();



        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}


