using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Biblioteca
    {
        private string nomeBiblioteca;
        private int orarioApertura;     // Orario di apertura della biblioteca
        private int orarioChiusura;     // Orario di chiusura della biblioteca
        
        // Costruttore
        public Biblioteca(string nomeBiblioteca, int orarioApertura, int orarioChiusura) 
        { 
            this.nomeBiblioteca = nomeBiblioteca;
            this.orarioChiusura = orarioChiusura;
            this.orarioApertura = orarioApertura;
        }
    }
}
