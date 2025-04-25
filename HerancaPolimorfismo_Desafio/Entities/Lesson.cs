using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo_Desafio.Entities
{
    internal abstract class Lesson
    {
        public string Title { get; set; }

        //Construtor com parâmetros
        public Lesson(string title)
        {
            Title = title;            
        }

        //Método para calcular a duração
        public abstract int Duration();

        public override string ToString()
        {
            return $"Título: {Title}";
        }


    }
}
