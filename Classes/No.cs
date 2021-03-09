using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreGenerica.Classes
{
    public class No
    {
        private Object dados;
        private No noPai;
        private int profundidade = 0;
        private int altura = 0;
        private LinkedList<No> filhos;

        public No(Object dados)
        {
            this.dados = dados;
            this.filhos = new LinkedList<No>();
        }
        public No(Object dados, No noPai)
        {
            this(dados);
            this.noPai = noPai;
        }

        public No AddFilho(Object dadosFilho)
        {
            No n = new No(dadosFilho, this);
            this.noPai.setAltura(this.altura + 1);
            n.setProfundidade(this.profundidade + 1);
            filhos.AddLast(n);
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

        public int getGrau()
        {
            return filhos.Count;
        }

        public bool isFolha()
        {
            return filhos.Count == 0;
        }
        public bool isRaiz()
        {
            return this.noPai == null;
        }

        public int getProfundidade()
        {
            return this.profundidade;
        }

        private void setProfundidade(int profundidadeNova)
        {
            this.profundidade = profundidadeNova;
        }

        public int getAltura()
        {
            return this.altura;
        }

        private void setAltura(int novaAltura)
        {
            if (novaAltura > this.altura)
            {
                this.altura = novaAltura;
                if (!this.isRaiz())
                {
                    this.noPai.setAltura(novaAltura + 1);
                }
            }
        }
    }
}
