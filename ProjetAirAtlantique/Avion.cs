using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAirAtlantique
{
    class Avion
    {
        private int idAvion;
        public int IdAvion { get => idAvion; set => idAvion = value; }

        private int distanceParcourue;
        public int DistanceParcourue { get => distanceParcourue; set => distanceParcourue = value; }

        private int disponibilite;
        public int Disponibilite { get => disponibilite; set => disponibilite = value; }

        private Aeroport idAeroport;
        public Aeroport IdAeroport { get => idAeroport; set => idAeroport = value; }

        private Modele idModele;
        public Modele IdModele { get => idModele; set => idModele = value; }

        private Motorisation idMotorisation;
        public Motorisation IdMotorisation { get => idMotorisation; set => idMotorisation = value; }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string nomPropriete)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nomPropriete));
        }
    }
}
