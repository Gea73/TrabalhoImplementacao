using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class Categoria
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
        public override string ToString()
        {
            return $"Nome:{Nome} Descrição:{Descricao}";

        }

    }
}
