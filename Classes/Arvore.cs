using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreGenerica.Classes
{
    public class Arvore
    {
        private No Raiz;


        public Arvore(Object dadosRaiz)
        {
            this.Raiz = new No(dadosRaiz);
        }

        public No getRaiz()
        {
            return Raiz;
        }

        public No Buscar (Object procurado)
        {
            return Raiz.Buscar(procurado);
        }
    }
}
