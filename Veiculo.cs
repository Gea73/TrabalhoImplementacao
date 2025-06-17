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
            set { _marca = value; }
        }
        private string _modelo;
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        private double _valorLocacao;
        public double ValorLocacao
        {
            get { return _valorLocacao; }
            set { _valorLocacao = value; }
        }
        private Categoria _categoria;
        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        private bool _disponivel;
        public bool Disponivel
        {
            get { return _disponivel; }
            set { _disponivel = value; }
        }
        public Veiculo(string placa, string marca, string modelo, double valorLocacao, Categoria categoria)
        {
            _placa = placa;
            _marca = marca;
            _modelo = modelo;
            _valorLocacao = valorLocacao;
            _categoria = categoria;
            _disponivel = true;
        }
   

        public abstract void ExibirDetalhes();
    }

}
