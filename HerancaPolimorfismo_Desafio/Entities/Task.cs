using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HerancaPolimorfismo_Desafio.Entities
{
    internal class Task : Lesson
    {
        public string Description { get; set; }
        public int QuestionCount { get; set; }

        //Construtor padrão
        //Construtor padrão        

        //Construtor com parâmetros
        public Task(string title, string description, int questionCount) : base(title)
        {
            Description = description;
            QuestionCount = questionCount;
        }

        //Método para calcular duracao da tarefa
        public override int Duration()
        {
            return QuestionCount * 300; // 5 minutos por questão = 300 segundos
        }

        public override string ToString()
        {
            return $"Título: {Title}, Descrição: {Description}, Questões: {QuestionCount}, Duração: {Duration()} segundos";
        }

    }
}
