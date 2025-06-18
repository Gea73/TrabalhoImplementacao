using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class MenuOpcoes
    {

        public void MostrarMenu()
        {
            CadCategorias cadCategorias = new CadCategorias();
            CadLocacao cadLocacao = new CadLocacao();
            CadVeiculos cadVeiculos = new CadVeiculos();

            bool aberto = true;
            EntradaDados entradaDados = new EntradaDados();
            while (aberto)
            {
                Console.WriteLine("1.Cadastrar categoria:");
                Console.WriteLine("2.Cadastrar veículos:");
                Console.WriteLine("3.Importar os dados das categorias de um arquivo CSV.");
                Console.WriteLine("4.Importar os dados dos veículos de um arquivo CSV");
                Console.WriteLine("5.Importar os dados das locações de um arquivo CSV.");
                Console.WriteLine("6.Listar todos os veículos, por tipo de veículo");
                Console.WriteLine("7.Realizar a locação de um veículo:");
                Console.WriteLine("8.Listar todas as locações realizadas.");
                Console.WriteLine("9.Calcular o faturamento previsto em um período.");
                Console.WriteLine("10.Exportar os dados cadastrados para arquivos CSV.");
                Console.WriteLine("11.Sair.");
                int escolha = entradaDados.LeInteiro("Digite uma opção:");
                switch (escolha)
                {
                    case 1:
                        string nome = entradaDados.LeString("Digite o nome da categoria");
                        string descricao = entradaDados.LeString("Digite a descrição da categoria");
                        Categoria categoria = new Categoria(nome, descricao);
                        cadCategorias.Inserir(categoria);
                        break;
                    case 2:
                        int cadastrar = entradaDados.LeInteiro("Cadastrar:1.Carro 2.Moto 3.Caminhão");
                        if (cadastrar == 1)
                        {

                        }
                        else if (cadastrar == 2)
                        {

                        }
                        else if (cadastrar == 3)

                        {

                        }
                        else
                        {
                            Console.WriteLine("Opção invalida");
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:

                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    default:
                        Console.WriteLine("Erro no menu");
                        break;
                }

            }
        }


    }
}
