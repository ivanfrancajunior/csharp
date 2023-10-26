using System;
using System.Reflection.PortableExecutable;
using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("S = segundos => 10s  = 10 segundos");
            Console.WriteLine("M = minutos => 1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja marcar?");
            string opcao = Console.ReadLine().ToLower();


            char type = char.Parse(opcao.Substring(opcao.Length - 1, 1));
            int time = int.Parse(opcao.Substring(0, opcao.Length - 1));
            int multiplier = 1;


            if (type == 's')
            {
                Start(type, time);
                return;
            }
            else if (type == 'm')
            {
                multiplier = 60;
                int timeInMinutes = time * multiplier;
                Start(type, timeInMinutes);
                return;
            }
            else
            {
                System.Environment.Exit(0);

            }



        }
        static void Start(char type, int time)
        {
            int currentTime = 0;

            {
                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);

                }
                Console.WriteLine("Tempo finalizado!");
                Thread.Sleep(2000);
                Menu();

            }

        }
    }

}

