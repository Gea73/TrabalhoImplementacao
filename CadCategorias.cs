using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeanCarlosRamosOliveira
{
    public class CadCategorias
    {
        private Categoria[] _categorias;
        private int _indice;
        private const int TAM = 5;

        public CadCategorias()
        {
            _categorias = new Categoria[TAM];
            _indice = 0;
        }


        public void Inserir(Categoria categoria)
        {
            if (_indice < TAM)
            {
                _categorias[_indice] = categoria;
                _indice++;
            }
        }
        public Categoria[] Categorias
        {
            get { return _categorias; }
        }

        public Categoria RetornaCategoria(string texto)
        {
            Categoria categoria = null;

            foreach (Categoria categorias in _categorias)
            {
                if (categorias.Equals(texto))
                {
                    categoria = categorias;
                }
            }
           

                return categoria;
        }
        public int Tamanho()
        {
            return _indice;
        }

    }
}

