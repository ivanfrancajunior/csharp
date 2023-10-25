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

            var mouse = new Product(1, "Mouse Poderoso", 100.50, EProductType.Product);

            Console.WriteLine(mouse.Id);

            Console.WriteLine(EDiasDaSemana.Domingo);
        }
    }


    struct Product
    {

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;

        }
        public int Id;
        public double Price;
        public string Name;
        public EProductType Type;

        public double PriceInDolar(float dolar)
        {
            return Price * dolar;
        }

    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
    public enum EDiasDaSemana
    {
        Domingo,
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sábado
    }

}

