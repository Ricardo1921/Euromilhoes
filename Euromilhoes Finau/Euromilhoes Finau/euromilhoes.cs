using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro
{
    class euromilhoes
    {
        private int nestrela = 0, nnumeros = 0;

        private const string cruz = "X";
        private bool[] numeros = new bool[50];
        private bool[] estrelas = new bool[12];

        public int[] nsorteia => sorteia(5, 50);

        public int[] sorteia => sorteia(5, 50);

        public string numero(int n)
        {
            if (numeros[n])
            {
                numeros[n] = false;
                nnumeros--;
            }

            else if (nnumeros < 5)
            {
                numeros[n] = true;
                nnumeros++;
            }
            if (numeros[n]) return cruz;
            else return "";

        }
        public string estrela(int n)
        {
            if (estrelas[n])
            {
                estrelas[n] = false;
                nestrela--;
            }

            else if (nestrela < 2)
            {
                estrelas[n] = true;
                nestrela++;
            }
            if (estrelas[n]) return cruz;
            else return "";

        }
        public string listanum
        {
            get
            {
                string lista = "";
                for (int i = 0; i < 50; i++)
                    if (numeros[i])
                    {
                        if (lista != "") lista += "+";
                        lista += (i + 1).ToString();
                    }
                return lista;
            }
        }
        public string listaest
        {
            get
            {
                string lista = "";
                for (int i = 0; i < 12; i++)
                    if (estrelas[i])
                    {
                        if (lista != "") lista += "+";
                        lista += (i + 1).ToString();
                    }
                return lista;
            }
        }
        public int[] sorteias(int qtd, int max)
        {
            List<int> l = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < qtd; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, max + 1);
                while (l.Contains(tmp));
                l.Add(tmp);
            }
            l.Sort();
            return l.ToArray();


        }

    }
}