using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumemacaoComposicao_DesafioEmpregados.Entities
{
    internal class Employees
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        
        //Construtor padrao
        public Employees()
        {
        }

        //Construtor com parametro (argumento)
        public Employees(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        //Metodo erride para retornar o texto do comentariopara adicionar comentario
        public override string ToString()
        {
            return Name + " - " + Salary.ToString("F2");
        }
    }
}
