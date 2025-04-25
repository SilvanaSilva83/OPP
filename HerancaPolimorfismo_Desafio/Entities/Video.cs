using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo_Desafio.Entities
{
    internal class Video : Lesson
    {
        public string Url { get; set; }
        public int Segundos { get; set; }

        //Construtor com parâmetros
        public Video(string title,  string url,int segundos) : base(title)
        {
            Url = url;
            Segundos = segundos;
        }

        //Método para calcular a duração
        public override int Duration()
        {
            return Segundos;
        }

        public override string ToString()
        {
            return $"Título: {Title}, Url: {Url}, Duração: {Segundos} segundos";
        }
    }
}
