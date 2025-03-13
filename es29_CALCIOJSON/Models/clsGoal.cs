using System;

namespace es29_CALCIOJSON.Models
{
    class clsGoal
    {
        private clsGiocatore marcatore;
        private int idPartita;
        private int numero;
        private int minuto;
        private bool autogoal;

        public int IdPartita { get => idPartita; set => idPartita = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Minuto
        {
            get => minuto.ToString(); set
            {
                if (!int.TryParse(value, out minuto) || minuto <= 0 || minuto > 90) throw new Exception("Minuto non valido, intero compreso tra 0 e 90");
            }
        }
        //volevo gestire qui il controllo che il marcatore fosse in una squadra della partita
        //non posso perchè questo dato è nell'altra classe. Immagino avrò lo stesso problema
        //di là
        public clsGiocatore Marcatore { get => marcatore; set => marcatore = value; }

        public bool Autogoal { get => autogoal; set => autogoal = value; }

        public clsGoal(int _idPartita, clsGiocatore _marcatore, string _minuto, bool _autogoal)
        {
            IdPartita = _idPartita;
            Marcatore = _marcatore;
            Minuto = _minuto;
            Autogoal = _autogoal;
        }
        public clsGoal() { }
        internal string Visuazza()
        {
            string auto = "- Autogoal";
            if (!Autogoal) auto = ""; 
            return $"{Marcatore.Visualizza()} - minuto:{Minuto} {auto}";
        }
    }
}
