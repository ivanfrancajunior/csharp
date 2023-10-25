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

        }



    }

}

