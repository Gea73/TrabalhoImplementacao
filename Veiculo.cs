using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public abstract class Veiculo
    {
        private string _placa;
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        private string _marca;

        public string Marca
        {
            get { return _marca; }
            private set{_marca = value;}
        }

        private string _modelo;
        public string Modelo
        {
            get { return _modelo; }
            private set { _modelo = value; }

        }
        public double ValorLocacao { get;private set; }
        public Categoria Categoria { get;private set; }
        public bool Disponivel { get; set; }

        public Veiculo(string placa, string marca, string modelo, double valorLocacao, Categoria categoria)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            ValorLocacao = valorLocacao;
            Categoria = categoria;
            Disponivel = true;
        }

        public abstract void ExibirDetalhes();
    }

}
