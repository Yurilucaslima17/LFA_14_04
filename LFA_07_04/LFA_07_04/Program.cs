using LFA_07_04.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA_07_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();

            List<char> simbolos = new List<char>() { '0', '1', '2', '3', 'S', 'A' };
            List<char> terminais = new List<char>() { '0', '1', '2', '3' };
            List<Regra> regras = new List<Regra>() { 
                new Regra() { De = "S", Para = "S3" },
                new Regra() { De = "S", Para = "A" },
                new Regra() { De = "A", Para = "1" }, 
                new Regra() { De = "A", Para = "0" } 
            };
            string r = "S";

            metodos.Classificador(regras, simbolos, terminais, r);



        }

        

    }

    

}
