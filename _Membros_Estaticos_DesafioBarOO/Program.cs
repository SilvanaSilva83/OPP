using System;
using System.Globalization;
using System.Net.Sockets;
using System.Reflection;

namespace _Membros_Estaticos_DesafioBarOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os seguintes dados de
            Console.Write("Sexo: \t\t\t\t");
            Bill.gender = char.Parse(Console.ReadLine());

            Console.Write("Quantidade de cervejas: \t");
            Bill.beer = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de refrigerantes: \t");
            Bill.softDrink = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de espetinhos: \t");
            Bill.barbecue = int.Parse(Console.ReadLine());

            // Chamar os métodos
            double Feeding = Bill.Feeding
                (Bill.beer, Bill.barbecue, Bill.softDrink); //Total do consumo
            double Couvert = Bill.Courvert(Feeding);
            double Ticket = Bill.Ticket(Bill.gender);//Valor do ingresso
            double Total = Bill.TotalBill(Feeding, Couvert, Ticket);

            Console.WriteLine("\n--------- RELATORIO ---------\n");

            Console.WriteLine($"Valor consumo \t= \t\tR$ {Feeding.ToString("F2", CultureInfo.InvariantCulture)}");             

            Console.WriteLine($"Couvert \t= \t\tR$ {Couvert.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Ingressos \t= \t\tR$ {Ticket.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Valor a pagar \t= \t\tR$ {Total.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
