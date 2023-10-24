// See https://aka.ms/new-console-template for more information
using MeuApp.Test;
using Microsoft.VisualBasic;

namespace MeuApp
{

    class Program
    {

        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.8f;

            string valorReal = real.ToString();
            Console.WriteLine(valorReal);

            inteiro = Convert.ToInt32(real);
            Console.WriteLine(inteiro);

            int divisao = Convert.ToInt32(22f / 5f);
            Console.WriteLine(divisao);
            var value = "4";

            int notMoreString = int.Parse(value);
            Console.WriteLine(notMoreString);


        }



    }

}

