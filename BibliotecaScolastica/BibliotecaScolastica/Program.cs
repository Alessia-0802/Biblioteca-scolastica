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

            Console.WriteLine("Inserisci il nome della biblioteca a cui vuoi accedere");
            string nomeBiblioteca = Console.ReadLine();

            int orarioApertura = 9;

            int orarioChiusura = 21;
            Console.WriteLine("\nInserisci il nome del libro:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nInserisci l'autore del libro:");
            string autore = Console.ReadLine();

            Console.WriteLine("\nInserisci il numero di pagine del libro:");
            string numeroPagine = Console.ReadLine();

            Console.WriteLine("\n Vuoi confermare la creazione del libro?");
            string risposta = Console.ReadLine();
            
            Libro libro = new Libro(nome, autore, numeroPagine);
            Biblioteca biblioteca = new Biblioteca(nomeBiblioteca, orarioApertura, orarioChiusura);
            
            if (risposta == "si")
            {
                libro.ToString();
            }
            
            // Richiesta all'utente di scegliere l'azione che vuole apporttare
            Console.WriteLine("Diita 1 per accedere alle informazioni riguardo alla biblioteca");
            Console.WriteLine("Digita 2 per visualizare la media del tempo di lettura");
            Console.WriteLine("Digita 3 se vuoi sucire dal programma definitivamente");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    libro.readingTime();
                break;

                case "2":
                    // Collegamento con la biblioteca per visualizare il le informazioni relative alla biblioteca
                break;

                case "3":
                    Console.WriteLine("Grazie per aver usato il nostro servizio online");
                return;

            }
        }
    }
}
