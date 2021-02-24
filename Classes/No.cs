using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreGenerica.Classes
{
    public class No
    {
        private Object dados;
        private List<No> filhos;

        public No(Object dados)
        {
            this.dados = dados;
            this.filhos = new List<No>();
        }

        public No AddFilho(Object dadosFilho)
        {
            No n = new No(dadosFilho);
            filhos.Add(n);
            return n;
        }

        public Object getDados()
        {
            return dados;
        }

        public List<No> getFilhos()
        {
            return filhos;
        }

        public No Buscar (Object procurado)
        {
            if(filhos.Exists(m => m.dados == procurado))
            {
                return filhos.Find(m => m.dados == procurado);
            }
            return null;
        }
    }
}
