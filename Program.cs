// See https://aka.ms/new-console-template for more information
using MeuApp.Test;
using Microsoft.VisualBasic;

namespace MeuApp
{

    class Program
    {

        static void Main(string[] args)
        {
            double value = 2.500;
            float salario = 2.500f;
            decimal salarioAnual = 2.500m;
            char primeiraLetra = 'a';
            char segundaLetra = 'b';
            string cadeiaCaracteres = "sou uma string";

            // int inteiro = 100;
            int inteiro;
            
            double inteiroForFloat = inteiro + 0.5;
            uint inteiroSemSinal = (uint)inteiro;

            int? idade = null;
            bool smart = false;
            var texto = "Testandoo";
            Console.WriteLine(value);
            Console.WriteLine(salario);
            Console.WriteLine(salarioAnual);
            Console.WriteLine(primeiraLetra);
            Console.WriteLine(segundaLetra);
            Console.WriteLine(cadeiaCaracteres);
            Console.WriteLine(idade);
            Console.WriteLine(texto);
            Console.WriteLine(smart);
            Console.WriteLine(inteiroSemSinal);
            Console.WriteLine(inteiroForFloat);

        }



    }

}

