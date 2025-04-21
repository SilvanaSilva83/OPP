namespace Contrutores_This_Sobre_Encap_DesafioCombate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciação de um objeto
            Champion champion1; 
            Champion champion2;

            //Inputacao de dados
            Console.WriteLine("CAMPEÕES");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Digite os dados do Primeiro Campeao");
            Console.Write("Nome: \t");
            string name = Console.ReadLine();
            Console.Write("Vida Inicial: \t");
            int life = int.Parse(Console.ReadLine());
            Console.Write("Ataque: \t");
            int attack = int.Parse(Console.ReadLine());
            Console.Write("Armadura: \t");
            int armor = int.Parse(Console.ReadLine());
            champion1 = new Champion(name, life, attack, armor);

            Console.WriteLine("\n------------------------------\n");

            Console.WriteLine("Digite os dados do Segundo Campeao");
            Console.Write("Nome: \t");
            name = Console.ReadLine();
            Console.Write("Vida Inicial: \t");
            life = int.Parse(Console.ReadLine());
            Console.Write("Ataque: \t");
            attack = int.Parse(Console.ReadLine());
            Console.Write("Armadura: \t");
            armor = int.Parse(Console.ReadLine());
            champion2 = new Champion(name, life, attack, armor);

            Console.WriteLine("\n------------------------------\n");
            Console.WriteLine("Quantos turnos voce deseja executar: ");
            int rodadas = int.Parse(Console.ReadLine());            
            Console.WriteLine("------------------------------");

            // Lógica do combate e exibição do resultado e status
            for (int i = 1; i <= rodadas; i++)
            {
                if (champion1.Life == 0 || champion2.Life == 0)
                {
                    break;
                }

                champion1.TakeDamage(champion2);                
                champion2.TakeDamage(champion1);

                Console.WriteLine("Rodada " + i);
                Console.WriteLine(champion1.ToString());                
                Console.WriteLine(champion2.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Fim do combate!");
            Console.WriteLine(champion1.Status());
            Console.WriteLine(champion2.Status());

        }
    }
}
   
