using es29_CALCIOJSON.View;
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
        private int numero;
        private int idPartita;

        public string Minuto { get =>minuto.ToString(); set
            {
                if (!int.TryParse(value, out minuto)||minuto<=0||minuto>90) throw new Exception("Minuto non valido, intero compreso tra 0 e 90");
            } }

        public bool Autogoal { get => autogoal; set => autogoal = value; }
        public int IdPartita { get => idPartita; set => idPartita = value; }
        internal clsGiocatore Marcatore { get => marcatore; set => marcatore = value; }
        public int Numero { get => numero; set => numero = value; }

        public clsGoal(int _idPartita,clsGiocatore _marcatore, string _minuto, bool _autogoal)
        {
            IdPartita = _idPartita;
            Marcatore = _marcatore;
            Minuto = _minuto;
            Autogoal = _autogoal;
        }

        internal string Visuazza()
        {
            return $"{Marcatore.Visualizza()}\n{Minuto} - {Autogoal}";
        }
    }
}
