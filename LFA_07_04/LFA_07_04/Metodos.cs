using LFA_07_04.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA_07_04
{
    class Metodos
    {
        public void Classificador(List<Regra> regras, List<char> simbolos, List<char> terminais, string inicial )
        {
            List<char> n = new List<char>();

            foreach (char item in simbolos)
            {
                if (!terminais.Contains(item))
                {
                    n.Add(item);
                }
            }

            if (IsLinear(regras, n))
            {
                Console.WriteLine("Gramática Linear");
            }
            else if (IsLivre(regras, n))
            {
                Console.WriteLine("Gramática Livre de Contexto");
            }
            else if (IsSensivel(regras, n))
            {
                Console.WriteLine("Gramática Sensível ao Contexto");
            }
            else
            {
                Console.WriteLine("Grámatica Irrestrita");
            }

        }

        public bool IsLinear(List<Regra> regras, List<char> n)
        {

            foreach(Regra regra in regras)
            {
                var alfa = regra.De;
                var beta = regra.Para;
                var aux = false;

                foreach (char simbolo in alfa)
                {
                    if (!n.Contains(simbolo))
                    {
                        aux = true;
                    }
                }

                if (alfa.Length != 1 || aux == true)
                {
                    return false;
                }
                if (beta.Length > 1)
                {
                    var contador = 0;
                    foreach(char simbolo in beta)
                    {
                        if (n.Contains(simbolo))
                        {
                            contador += 1;
                        }
                    }
                    if (contador > 1)
                        return false;
                    if (!n.Contains(beta.First()) && contador == 1)
                        return false;
                }
            }
            return true;
        }

        public bool IsLivre(List<Regra> regras, List<char> n)
        {
            foreach(Regra regra in regras)
            {
                var alfa = regra.De;
                var beta = regra.Para;

                foreach (char simbolo in alfa)
                {
                    if (!n.Contains(simbolo))
                        return false;
                }
            }
            return true;
        }

        public bool IsSensivel(List<Regra> regras, List<char> n)
        {
            foreach (Regra regra in regras)
            {
                var alfa = regra.De;
                var beta = regra.Para;
                if(alfa.Length > beta.Length)
                {
                    return false;
                }
                foreach (char simbolo in alfa)
                {
                    if (!n.Contains(simbolo))
                        return false;
                }
            }
                return true;
        }
    }
}
