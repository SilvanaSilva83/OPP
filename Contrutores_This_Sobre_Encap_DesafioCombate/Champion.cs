using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrutores_This_Sobre_Encap_DesafioCombate
{
    internal class Champion
    {
        //Atributos
        public string Name { get; set; }
        public int Life { get; set; }
        public int Attack { get; set; }
        public int Armor { get; set; }

        //Construtores           // Analogia = Um forma de bolo pra diferentes sabores de bolo
        public Champion(string name, int life, int attack, int armor)
        {
            this.Name = name;
            this.Life = life;
            this.Attack = attack;
            this.Armor = armor;
        }//Sei que o this nao e necessario, mas por uma questao de didatica prefiro incluir

        //Métodos
        public void TakeDamage(Champion other)
        {
            int damage = other.Attack - this.Armor;
            if (damage < 1)
            {
                damage = 1;
            }

            this.Life -= damage;

            if (this.Life < 0)
            {
                this.Life = 0;                
            }
        }

        public string Status()
        { 
            if (this.Life > 0)
            {
                return this.Name+" Esta vivo";
            }
            else
            {
                return this.Name+" Esta morto";
            }

        }

        public override string ToString()
        {
            return "Nome: "
                + Name
                + "\t"
                + Life
                + " de vida";               
        }
    }
}
