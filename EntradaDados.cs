using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    internal class EntradaDados
    {
        public string LeString(string mensagem)
        {
            string input;
            Console.WriteLine(mensagem);
            input = Console.ReadLine();
            return input;
        }
        public double LeDouble(string mensagem)
        {
            string input = string.Empty;
            double valor = 0;

            Console.WriteLine(mensagem);
            input = Console.ReadLine();

            while (!double.TryParse(input, out valor))
            {
                Console.WriteLine("Valor incorreto. Digite Novamente");

                Console.WriteLine(mensagem);
                input = Console.ReadLine();
            }
            return valor;
        }
        public int LeInteiro(string mensagem)
        {
            string input = string.Empty;
            int valor = 0;

            Console.WriteLine(mensagem);
            input = Console.ReadLine();

            while (!int.TryParse(input, out valor))
            {
                Console.WriteLine("Valor incorreto. Digite Novamente");

                Console.WriteLine(mensagem);
                input = Console.ReadLine();
            }
            return valor;
        }

    }
}