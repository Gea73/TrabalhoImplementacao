﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class Locacao
    {
        private int _identificacao;
        public int Identificacao
        {
            get { return _identificacao; }
            set { _identificacao = value; }
        }

        private Veiculo _veiculo;
        public Veiculo Veiculo
        {
            get { return _veiculo; }
            set { _veiculo = value; }
        }

        private DateTime _dataInicial;
        public DateTime DataInicial
        {
            get { return _dataInicial; }
            set { _dataInicial = value; }
        }

        private DateTime _dataFinal;
        public DateTime DataFinal
        {
            get { return _dataFinal; }
            set { _dataFinal = value; }
        }

        private double _valor;
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Locacao(int identificacao, Veiculo veiculo, DateTime dataInicial, DateTime dataFinal, double valor)
        {
            _identificacao = identificacao;
            _veiculo = veiculo;
            _dataInicial = dataInicial;
            _dataFinal = dataFinal;
            _valor = valor;
        }

        public override string ToString()
        {
            return $"Indetificação:{Identificacao} Veiculo:{Veiculo} Data Inicial:{DataInicial} Data Final:{DataFinal} Valor{Valor}";
        }
    }
}
