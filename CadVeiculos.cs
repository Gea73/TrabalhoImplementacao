using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class CadVeiculos
    {
        Veiculo[] _veiculos { get; set; }
        private int _indice;
        private const int TAM = 5;

        public CadVeiculos()
        {
            _veiculos = new Veiculo[TAM];
            _indice = 0;
        }


        public void Inserir(Veiculo veiculo)
        {
            if (_indice < TAM)
            {
                _veiculos[_indice] = veiculo;
                _indice++;
            }
        }
        public Veiculo[] Veiculos
        {
            get { return _veiculos; }
        }

        public Veiculo RetornaVeiculo(string placa)
        {
            Veiculo veiculo = null;

            foreach (Veiculo veiculos in _veiculos)
            {
                if (veiculos.Equals(placa))
                {
                    veiculo = veiculos;
                }
            }

            return veiculo;
        }
        public int Tamanho()
        {
            return _indice;
        }

    }

}

