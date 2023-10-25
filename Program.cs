// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.VisualBasic;

namespace MeuApp
{

    class Program
    {

        static void Main(string[] args)
        {
            bool? valor = null;

            switch (valor)
            {
                case true: Console.WriteLine("Verdadeiro"); break;
                case false: Console.WriteLine("False"); break;
                default: Console.WriteLine("Null"); break;
            }
            // for (var i = 0; i < 20; i++) Console.WriteLine(i);

            for (var i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            var numero = 10;
            // while (numero <= 20)
            // {
            //     Console.WriteLine(numero);
            //     numero++;
            // }

            do
            {
                Console.WriteLine(numero);
                numero++;

            }
            while (numero <= 30);
        }



    }

}

