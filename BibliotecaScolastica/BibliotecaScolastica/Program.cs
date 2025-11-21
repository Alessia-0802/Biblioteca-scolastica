using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto");

            Console.WriteLine("\nInserisci il nome del libro:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nInserisci l'autore del libro:");
            string autore = Console.ReadLine();

            Console.WriteLine("\nInserisci il numero di pagine del libro:");
            string numeroPagine = Console.ReadLine();

            Console.WriteLine("Vuoi confermare la creazione del libro?");
            string risposta = Console.ReadLine();
            
            if (risposta == "si")
            {
                Libro lib = new Libro(nome, autore, numeroPagine);
            }
        }
    }
}
