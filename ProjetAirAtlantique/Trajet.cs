using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAirAtlantique
{
    class Trajet
    {
        private int idTrajet;
        public int IdTrajet { get => idTrajet; set => idTrajet = value; }

        private double distance;
        public double Distance { get => distance; set => distance = value; }

        private TimeSpan tempsEstime;
        public TimeSpan TempsEstime { get => tempsEstime; set => tempsEstime = value; }

        private Aeroport idAeroportD;
        public Aeroport IdAeroportD { get => idAeroportD; set => idAeroportD = value; }

        private Aeroport idAeroportA;
        public Aeroport IdAeroportA { get => idAeroportA; set => idAeroportA = value; }
    }
}
