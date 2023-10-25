// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.VisualBasic;

namespace MeuApp
{

    class Program
    {

        static void Main(string[] args)
        {
            int a = 5;
            int b = a; // 'b' recebe uma cópia de 'a'

            a = 75; // 'b' e não é alterado'
            Console.WriteLine(a);
            Console.WriteLine(b);

        }




    }

}

