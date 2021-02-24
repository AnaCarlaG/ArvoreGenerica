using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreGenerica.Classes
{
    public class Arvore
    {
        private No Raiz;


        public Arvore(int dadosRaiz)
        {
            this.Raiz = new No(dadosRaiz);
        }

        public No getRaiz()
        {
            return Raiz;
        }

        public No Buscar (int procurado)
        {
            return Raiz.Buscar(procurado);
        }
    }
}
