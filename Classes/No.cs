using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreGenerica.Classes
{
    public class No
    {
        private Object dados;
        private LinkedListNode<No> filhos;

        public No(Object dados)
        {
            this.dados = dados;
            this.filhos = new LinkedListNode<No>(new No(dados));
        }

        public No AddFilho(Object dadosFilho)
        {
            No n = new No(dadosFilho);
            if (filhos.List.Count != 0)
            {
                filhos.List.AddAfter(filhos.List.First, n);
            }
            else
            {
                filhos.List.AddFirst(n);
            }

            if (filhos.List.First != null)
            {
                var prox = filhos.List.First.Next;

                filhos.List.AddAfter(prox, n);
            }
            return n;
        }

        public Object getDados()
        {
            return dados;
        }

        public LinkedListNode<No> getFilhos()
        {
            return filhos;
        }

        //public No Buscar(Object procurado)
        //{
        //}
    }
}
