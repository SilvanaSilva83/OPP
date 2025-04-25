using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumemacaoComposicao_DesafioEmpregados.Entities
{
    internal class Department
    {
        public string Name { get; set; }
        public int PayDay { get; set; }

        public Address Address { get; set; }

        public List<Employees> Employees { get; set; } = new List<Employees>();
        
        //Construtor padrao
        public Department()
        {
        }

        //Construtor com parametro (argumento)
        public Department(string name, int payDay, Address address)
        {
            this.Name = name;
            this.PayDay = payDay;
            this.Address = address;
            
        }

        //Metod add para adicionar um empregado
        public void AddEmployee(Employees employee)
        {
            Employees.Add(employee);
        }

        //Metodo remove para remover um empregado
        public void RemoveEmployee(Employees employee)
        {
            Employees.Remove(employee);
        }

        //Metodo Payroll para calcular o salario total
        public double Payroll()
        {
            double sum = 0.0;
            foreach (Employees employee in Employees)
            {
                sum += employee.Salary;
            }
            return sum;
        }

        //Metodo erride para retornar o texto do comentariopara adicionar comentario
        public override string ToString()
        {
            return "Department: " + Name
                + "\n Folha de Pagamento: R$ " + Payroll().ToString("F2")
                + "\n Pagamento realizado no dia " + PayDay                
                + "\n Funcionarios: " + Employees.Count
                + "\n Para duvidas favor entrar em contato: " + Address;

        }
    }
}
