using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es29_CALCIOJSON.Models
{
    class clsGoal
    {
        private clsGiocatore marcatore;
        private int minuto;
        private bool autogoal;
        //private int numero;
        private int idPartita;

        public string Minuto { set
            {
                if (!int.TryParse(value, out minuto)||minuto<=0||minuto>90) throw new Exception("Minuto non valido, intero compreso tra 0 e 90");
            } }

        public bool Autogoal { get => autogoal; set => autogoal = value; }
        public int IdPartita { get => idPartita; set => idPartita = value; }
        internal clsGiocatore Marcatore { get => marcatore; set => marcatore = value; }
    }
}
