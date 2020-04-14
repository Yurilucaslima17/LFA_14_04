using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA_07_04
{
    class Metodos
    {
        public void Classificador(List<List<string>> regras, List<string> simbolos, List<string> terminais, string inicial )
        {
            List<string> n = new List<string>();

            foreach (string item in simbolos)
            {
                if (!terminais.Contains(item))
                {
                    n.Add(item);
                }
            }

            if (IsLinear())
            {
                Console.WriteLine("É Linear");
            }
            else if (IsLivre())
            {

            }
            else if (IsSensivel())
            {

            }
            else
            {
                Console.WriteLine("Grámatica Irrestrita");
            }

        }
        //regras.Add("S", "S2");
        public bool IsLinear()
        {
            return false;
        }

        public bool IsLivre()
        {
            return false;
        }

        public bool IsSensivel()
        {
            return false;
        }
    }
}
