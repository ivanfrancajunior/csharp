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

            int? idade = null;

            var texto = "Testandoo";
            Console.WriteLine(value);
            Console.WriteLine(salario);
            Console.WriteLine(salarioAnual);
            Console.WriteLine(primeiraLetra);
            Console.WriteLine(segundaLetra);
            Console.WriteLine(cadeiaCaracteres);
            Console.WriteLine(idade);
            Console.WriteLine(texto);

        }

    }
}

