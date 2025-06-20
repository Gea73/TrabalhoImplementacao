﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class Moto : Veiculo
    {
        private int _cilindrada;
        public int Cilindrada
        {
            get { return _cilindrada; }
            set { _cilindrada = value; }
        }
        public Moto(string placa, string marca, string modelo, double valorLocacao, Categoria categoria, int cilindrada) : base(placa, marca, modelo, valorLocacao, categoria)
        {
            _cilindrada = cilindrada;
        }

        public override void ExibirDetalhes()
        {
            string disponivel;
            if (Disponivel)
            {
                disponivel = "Disponivel";
            }
            else
            {
                disponivel = "Não Disponivel";
            }
            Console.WriteLine($"Moto:{Marca} {Modelo}, {Cilindrada} cilindradas, Placa:{Placa}, Categoria:{Categoria.Nome}, Diária:R${ValorLocacao:F2}, Disponível:{disponivel}");
        }

        public override string ToString()
        {
            string disponivel;
            if (Disponivel)
            {
                disponivel = "Disponivel";
            }
            else
            {
                disponivel = "Não Disponivel";
            }
            return $"Moto:{Marca} {Modelo}, {Cilindrada} cilindradas, Placa:{Placa}, Categoria:{Categoria.Nome}, Diária:R${ValorLocacao:F2}, Disponível:{disponivel}";
        }
    }

}
