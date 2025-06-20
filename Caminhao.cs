﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class Caminhao : Veiculo
    {
        private double _capacidadeCargaToneladas;
        public double CapacidadeCargaToneladas
        {
            get { return _capacidadeCargaToneladas; }
            set { _capacidadeCargaToneladas = value; }
        }

        public Caminhao(string placa, string marca, string modelo, double valorLocacao, Categoria categoria, double capacidadeCargaToneladas)
        : base(placa, marca, modelo, valorLocacao, categoria)
        {
            _capacidadeCargaToneladas = capacidadeCargaToneladas;
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
            Console.WriteLine($"Caminhão: {Marca} {Modelo}, {CapacidadeCargaToneladas} Toneladas, Placa: {Placa}, Categoria: {Categoria.Nome}, Diária: R${ValorLocacao:F2}, {disponivel}");
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
            return $"Caminhão: {Marca} {Modelo}, {CapacidadeCargaToneladas} Toneladas, Placa: {Placa}, Categoria: {Categoria.Nome}, Diária: R${ValorLocacao:F2}, {disponivel}";
        }

    }

    
}
