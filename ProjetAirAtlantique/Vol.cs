using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAirAtlantique
{
    class Vol
    {
        private int idVol;
        public int IdVol { get => idVol; set => idVol = value; }

        private DateTime departPrevu;
        public DateTime DepartPrevu{ get => departPrevu; set => departPrevu = value; }

        private TimeSpan arriveePrevue;
        public TimeSpan ArriveePrevue { get => arriveePrevue; set => arriveePrevue = value; }

        private Aeroport idAeroportD;
        public Aeroport IdAeroportD { get => idAeroportD; set => idAeroportD = value; }

        private Aeroport idAeroportA;
        public Aeroport IdAeroportA { get => idAeroportA; set => idAeroportA = value; }
    }
}
