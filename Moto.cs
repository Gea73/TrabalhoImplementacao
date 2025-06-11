using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; private set; }

        public Moto(string placa, string marca, string modelo, double valorLocacao, Categoria categoria, int cilindrada)
            : base(placa, marca, modelo, valorLocacao, categoria)
        {
            Cilindrada = cilindrada;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Moto: {Marca} {Modelo}, {Cilindrada} cilindradas, Placa: {Placa}, Categoria: {Categoria.Nome}, Diária: R${ValorLocacao:F2}, Disponível: {Disponivel}");
        }
    }

}
