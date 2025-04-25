using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumemacaoComposicao_DesafioEmpregados.Entities
{
    internal class Address
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        //Construtor padrao
        public Address()
        {
        }

        //Construtor com parametro (argumento)
        public Address(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }

        //Metodo erride para retornar o texto do comentariopara adicionar comentario
        public override string ToString()
        {
            return "Email: " + Email + ", Phone: " + Phone;
        }
    }
}
