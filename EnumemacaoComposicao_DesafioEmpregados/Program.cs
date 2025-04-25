using System;
using System.Collections.Generic;
using System.Xml.Linq;
using EnumemacaoComposicao_DesafioEmpregados.Entities;

namespace EnumemacaoComposicao_DesafioEmpregados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldWidth = 35;

            Console.Write($"{"Nome do departamento:".PadRight(fieldWidth)}");
            string departmentName = Console.ReadLine();
            Console.Write($"{"Dia do pagamento:".PadRight(fieldWidth)}");
            int payDay = int.Parse(Console.ReadLine());
            Console.Write($"{"Email:".PadRight(fieldWidth)}");
            string email = Console.ReadLine();
            Console.Write($"{"Telefone:".PadRight(fieldWidth)}");
            string phone = Console.ReadLine();
            //Criando o departamento
            //Criando lista de empregados
            
            Address address = new Address(email, phone);
            Department department = new Department(departmentName, payDay, address);            
            
            Console.Write($"{"Quantos funcionarios tem o departamento? ".PadRight(fieldWidth)}");
            int qtyEmployees = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtyEmployees; i++)
            {                
                Console.WriteLine($"Dados do funcionario #{i}:");
                Console.Write($"{"Nome: ".PadRight(fieldWidth)}");
                string name = Console.ReadLine();
                Console.Write($"{"Salario: ".PadRight(fieldWidth)}");
                double salary = double.Parse(Console.ReadLine());                                
                
                Employees employees = new Employees(name, salary);
                department.AddEmployee(employees);

            }

            // Chando o metodo ShowReport(Departament department)
            ShowReport(department);

            Console.WriteLine(ShowReport);
        }

        //Metodo Static void ShowReport(Departament department)
        static void ShowReport(Department department)
        {
            Console.WriteLine();
            Console.WriteLine(department.ToString());
            //Console.WriteLine($"{"<<< Relatorio de pagamento >>>".PadRight(35)}");
            //Console.WriteLine($"{"Departamento: ".PadRight(35)}{department.Name}");
            //Console.WriteLine($"{"Email: ".PadRight(35)}{department.Address.Email}");
            //Console.WriteLine($"{"Telefone: ".PadRight(35)}{department.Address.Phone}");
            //Console.WriteLine($"{"Dia do pagamento: ".PadRight(35)}{department.PayDay}");
            //Console.WriteLine($"{"Funcionarios: ".PadRight(35)}{department.L");
            //foreach (Employees employees in department.Employees)
            //{
            //    Console.WriteLine(employees);
            //}
        }
    }
}
