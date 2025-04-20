using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _Membros_Estaticos_DesafioBarOO
{
    internal class Bill
    {
        //Attributes
        public static char gender=' ';
        public static int beer;
        public static int barbecue;
        public static int softDrink;
        

        //Methds

        public static double Feeding(double beer, double barbecue, double softDrink)
        {
            //Valores
            double totalBeer = beer * 5.00;
            double totalBarbecue = barbecue * 7.00;
            double totalSoftDrink = softDrink * 3.00;

            //Calculo
            return totalBeer + totalBarbecue + totalSoftDrink;
        }

        public static double Courvert(double feeding)
        {
            return feeding > 30 ? 0 : 4; //consumo>30 reais, o couvert artístico = 0.     
        }

        public static double Ticket(char gender)
        {
            return gender == 'M' ? 10 : 8;
        }

        public static double TotalBill(double feeding, double couvert, double ticket)
        {
            return feeding + couvert + ticket;
        }



    }
}
