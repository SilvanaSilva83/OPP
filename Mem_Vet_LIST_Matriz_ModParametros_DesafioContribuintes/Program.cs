using System.Xml.Linq;
using System.Collections.Generic;

namespace Mem_Vet_LIST_Matriz_ModParametros_DesafioContribuintes
{
    internal class Program
    {
        static void Main(string[] args) 
        {         
            Console.Write("Quantos contribuintes voce vai digitar?\t");
            int numContribuintes = int.Parse(Console.ReadLine());
            
            List<TaxPayer> contribuintes = new List<TaxPayer>();
            
            Console.WriteLine("Digite os dados do 1o. Contribuinte: ");
            for (int i = 0; i < numContribuintes; i++)
            {
                bool check = false;
                while (!check)
                {
                    Console.WriteLine($"Contribuinte #{i + 1}");

                    Console.Write("Renda anual com salario:\t");
                    double salaryIncome = double.Parse(Console.ReadLine());

                    Console.Write("Renda anual com prestacao de servicos:\t");
                    double servicesIncome = double.Parse(Console.ReadLine());

                    Console.Write("Renda anual com ganho de capital:\t");
                    double capitalIncome = double.Parse(Console.ReadLine());

                    Console.Write("Gasto medicos: ");
                    double healthSpending = double.Parse(Console.ReadLine());

                    Console.Write("Gasto educacao: ");
                    double educationSpending = double.Parse(Console.ReadLine());

                    Console.WriteLine("\n---------- Confirme os dados digitados ----------\n");
                    Console.WriteLine($"Renda anual com salario: {salaryIncome}");
                    Console.WriteLine($"Renda anual com prestacao de servicos: {servicesIncome}");
                    Console.WriteLine($"Renda anual com ganho de capital: {capitalIncome}");
                    Console.WriteLine($"Gasto medicos: {healthSpending}");
                    Console.WriteLine($"Gasto educacao: {educationSpending}");
                    Console.WriteLine("\nConfirmar? (S/N)");
                    char confirmar = char.Parse(Console.ReadLine().ToUpper());
                    if (confirmar == 'S')
                    {
                        contribuintes.Add(new TaxPayer(salaryIncome, servicesIncome, capitalIncome, healthSpending, educationSpending)); // List
                     check = true;                    
                    }
                    else
                    {
                        Console.WriteLine("Digite os dados novamente.");
                    }
                    Console.WriteLine("");                                        
                }                
            }            

            foreach (TaxPayer contribuinte in contribuintes)
            {
                int count = 1;
                Console.WriteLine($"Resumo do {count}º contribuinte:");
                Console.WriteLine("Imposto bruto total: " + contribuinte.GrossTax.ToString("F2"));
                Console.WriteLine("Abatimento: " + contribuinte.TotalSpending.ToString("F2"));
                Console.WriteLine("Imposto devido: " + (contribuinte.NetTax.ToString("F2")));
            }

        }
    }
}
