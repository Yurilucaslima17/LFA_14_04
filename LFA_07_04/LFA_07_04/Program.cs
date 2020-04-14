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

            List<string> simbolos = new List<string>() { "0", "1", "2", "3", "S", "A" };
            List<string> terminais = new List<string>() { "0", "1", "2", "3" };
            List<List<string>> regras = new List<List<string>>() { 
                new List<string>() { "S", "S3" },
                new List<string>() { "S", "A" },
                new List<string>() { "A", "1" }, 
                new List<string>() { "A", "0" } 
            };
            string r = "S";

            metodos.Classificador(regras,simbolos,terminais, r);



        }

        

    }

    

}
