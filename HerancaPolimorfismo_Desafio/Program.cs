using HerancaPolimorfismo_Desafio.Entities;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace HerancaPolimorfismo_Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldWidth = 33;
            List<Lesson> list = new List<Lesson>();

            Console.Write($"{"Quantas aulas tem o curso:".PadRight(fieldWidth)}");
            int qtyAulas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtyAulas; i++)
            {
                Console.Write($"Aula 1 #" + i);
                Console.Write($"{"\nConteudo ou Tarefa (C / T)?".PadRight(fieldWidth)}");
                char typeAula = char.Parse(Console.ReadLine().Trim().ToUpper());
                
                Console.Write($"{"Titulo:".PadRight(fieldWidth)}");
                string titulo = Console.ReadLine();

                if (typeAula == 'C')
                {
                    Console.Write($"{"Url do video:".PadRight(fieldWidth)}");
                    string url = Console.ReadLine();


                    Console.Write($"{"Duracao em segundos:".PadRight(fieldWidth)}");
                    int duracao = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                    //Lista de videos aulas
                    list.Add(new Video(titulo, url, duracao));                        
                }
                else
                {
                    Console.Write($"{"Descricao:".PadRight(fieldWidth)}");
                    string descricao= Console.ReadLine();

                    Console.Write($"{"Quantidade de perguntas:".PadRight(fieldWidth)}");
                    int questionCount = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);


                    list.Add(new HerancaPolimorfismo_Desafio.Entities.Task(titulo, descricao, questionCount)); /// Aconteceu algum problema com a Class Task: "a classe Task do .NET, que já existe no namespace:System.Threading.Tasks.Task/// nao entendi. essa foi a solucao que encontre/ChatGpt..
                }

            }

            int sum = 0;
            foreach (Lesson lesson in list)
            {
                sum += lesson.Duration();
            }

            Console.WriteLine($"\nDURAÇÃO TOTAL DO CURSO: {sum} segundos");
        }
    }
}
