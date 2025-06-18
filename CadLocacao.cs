using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class CadLocacao
    {
        Locacao[] _locacoes;
        private int _indice;
        private const int TAM = 5;

        public CadLocacao()
        {
            _locacoes = new Locacao[TAM];
            _indice = 0;
        }


        public void Inserir(Locacao locacao)
        {
            if (_indice < TAM)
            {
                _locacoes[_indice] = locacao;
                _indice++;
            }
        }
        public Locacao[] Locacoes
        {
            get { return _locacoes; }
        }

        public Locacao RetornaLocacao(int indentificacao)
        {
            Locacao locacao = null;

            foreach (Locacao locacoes in _locacoes)
            {
                if (locacoes.Identificacao == indentificacao)
                {
                    locacao = locacoes;
                }
            }


            return locacao;
        }
        public int Tamanho()
        {
            return _indice;
        }

    }
}
