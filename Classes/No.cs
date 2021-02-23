using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreGenerica.Classes
{
    public class No
    {
        private int dados;
        private List<No> filhos;

        public No(int dados)
        {
            this.dados = dados;
            this.filhos = new List<No>();
        }

        public No AddFilho(int dadosFilho)
        {
            No n = new No(dadosFilho);
            filhos.Add(n);
            return n;
        }

        public int getDados()
        {
            return dados;
        }

        public List<No> getFilhos()
        {
            return filhos;
        }

        public No Buscar (int procurado)
        {
            if(filhos.Exists(m => m.dados == procurado))
            {
                return filhos.Find(m => m.dados == procurado);
            }
            return null;
        }
    }
}
