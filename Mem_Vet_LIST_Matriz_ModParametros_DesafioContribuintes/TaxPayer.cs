using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mem_Vet_LIST_Matriz_ModParametros_DesafioContribuintes
{
    internal class TaxPayer
    {
        public double SalaryIncome { get; set; }
        public double ServicesIncome { get; set; }
        public double CapitalIncome { get; set; }
        public double HealthSpending { get; set; }
        public double EducationSpending { get; set; }

        //Construtor

        public TaxPayer(double salaryIncome, double servicesIncome, double capitalIncome, double healthSpending, double educationSpending)
        {
            this.SalaryIncome = salaryIncome;
            this.ServicesIncome = servicesIncome;
            this.CapitalIncome = capitalIncome;
            this.HealthSpending = healthSpending;
            this.EducationSpending = educationSpending;
        }

        //Propriedades
        public double GrossTax => SalaryTax() + ServicesTax + CapitalTax;        
        public double TotalIncome => SalaryIncome + ServicesIncome + CapitalIncome;        
        public double TotalSpending => HealthSpending + EducationSpending;
        public double TaxRebate => TotalSpending > GrossTax * 0.30 ? GrossTax * 0.30 : TotalSpending;
        public double ServicesTax => ServicesIncome > 0 ? ServicesIncome * 0.15 : 0.0;
        public double CapitalTax => CapitalIncome > 0 ? CapitalIncome * 0.20 : 0;
        public double NetTax => GrossTax - TaxRebate;


        //Metodo
        public double SalaryTax()
        {
            if (SalaryIncome < 3000*12) return 0.0;
            else if (SalaryIncome < 5000*12) return SalaryIncome * 0.10;
            else return SalaryIncome * 0.20; 
        }      
    }
}
