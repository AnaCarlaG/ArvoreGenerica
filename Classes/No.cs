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

        public void AddFilho(Object dadosFilho)
        {
            No n = new No(dadosFilho);

            filhos.List.AddLast(n);
        }

        public Object getDados()
        {
            return dados;
        }

        public LinkedListNode<No> getFilhos()
        {
            return filhos;
        }
    }
}
