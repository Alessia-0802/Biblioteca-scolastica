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
        private int orarioApertura;
        private int orarioChiusura;
        public Biblioteca(string nomeBiblioteca, int orarioApertura, int orarioChiusura) 
        { 
            this.nomeBiblioteca = nomeBiblioteca;
            this.orarioChiusura = orarioChiusura;
            this.orarioApertura = orarioApertura;
        }
    }
}
