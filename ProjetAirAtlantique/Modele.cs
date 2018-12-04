using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAirAtlantique
{
    class Modele
    {
        private int idModele;
        public int IdModele { get => idModele; set => idModele = value; }

        private string nomModele;
        public string NomModele{ get => nomModele; set => nomModele = value; }

        private int capacite;
        public int Capacite { get => capacite; set => capacite = value; }

        private int type;
        public int Type { get => type; set => type = value; }
    }
}
