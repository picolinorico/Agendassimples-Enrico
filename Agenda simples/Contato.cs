using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_simples
{
    internal class Contato
    {
        //variavéis internas da classe Contato
        //a palavra chave "private" indica que somente a classe "Contato" tem acesso
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        //PROPRIEDADES (GET E SET)
        public string Primeironome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }


        public string Sobrenome

        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string Telefone
        {
            get { return Telefone; }
            set
            {
                if (value.Length == 11)
                
                    Telefone = value;
                
                else
                
                    Telefone = "00-00000-0000";
                
            }
        }

        //Método construtor da classe 
        public Contato()
        {
            Primeironome = "José";
            Sobrenome = "Da Silva";
            Telefone = "11-98506-6098";
        }

        //Sobrecarga do método construtor da classe 
        public Contato(string primeiroNome, string sobrenome, string telefone)
        {
            Primeironome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            string saída = String.Empty;
            saída += String.Format("{0}, {1}", Primeironome, Sobrenome);
            saída += String.Format("{0}-{1}-{2}", 
                Telefone.Substring(0, 1), 
                Telefone.Substring(2, 4),
                Telefone.Substring(7, 3));

            return saída;
        }
    }
}
