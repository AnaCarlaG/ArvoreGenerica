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
            return raiz;
        }

        public No Buscar (int procurado)
        {
            Raiz.Buscar(procurado);
        }
    }
}
