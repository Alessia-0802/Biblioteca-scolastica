using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
    
        private string nome;
        private string autore;
        private int numeroPagine;

        public Libro(string nome, string autore, int numeroPagine)
        {
            this.nome = nome;
            this.autore = autore;
            this.numeroPagine = numeroPagine;
        }

        // Metodo per la restituzione dei valori degli attributi
        public override string ToString()
        {
            return $"Nome del libro: {nome}, Autore del libro: {autore}, Numero pagine deli libro: {numeroPagine}";
        }

        public void readingTime ()
        {
            if (numeroPagine < 100)
            {
                Console.WriteLine("Il tempo medio per leggere il libro sarà di 1h");

            }
            else if (numeroPagine > 100 && numeroPagine < 200)
            {
                Console.WriteLine("Il tempo medio per leggere il libro sarà di 2h");
            }
            else
            {
                Console.WriteLine("Il tempo megio per leggere il libro sarà di 3h");
            }
        }
    }
}
