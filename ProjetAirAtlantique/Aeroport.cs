using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAirAtlantique
{
    class Aeroport
    {
        private int idAeroport;
        public int IdAeroport { get => idAeroport; set => idAeroport = value; }

        private string ville;
        public string Ville { get => ville; set => ville = value; }

        private string nomAeroport;
        public string NomAeroport { get => nomAeroport; set => nomAeroport = value; }
    }
}
