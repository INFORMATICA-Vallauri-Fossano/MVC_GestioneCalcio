using System;
using System.Collections.Generic;

namespace es29_CALCIOJSON.Models
{
    class clsPartita
    {
        class goalList : IEnumerable<clsGoal>
        {
            IEnumerable<clsGoal> list;
            IEnumerable<clsGoal>.GetEnumerator(){

                }
        }
        int idPartita;
        string squadraCasa;
        string squadraOspite;
        string arbitro;


        goalList goalList=new goalList();

        public int IdPartita { get => idPartita; set => idPartita = value; }
        public string SquadraCasa
        {
            get => squadraCasa; set
            {
                if (value.Trim().Length < 2) throw new Exception("Squadra di Casa non valida, almeno 2 caratteri");
                else squadraCasa = value;
            }
        }
        public string SquadraOspite
        {
            get => squadraOspite; set
            {
                if (value.Trim().Length < 2) throw new Exception("Squadra Ospite non valida, almeno 2 caratteri");
                else squadraOspite = value;
            }
        }
        public string Arbitro
        {
            get => arbitro; set
            {
                if (value.Trim().Length < 2) throw new Exception("Arbitro non valido, almeno 2 caratteri");
                else arbitro = value;
            }
        }
        public List<clsGoal> GoalList { get => goalList; set => goalList = value; }
        public clsPartita() { }
        public clsPartita(int idPartita, string squadraCasa, string squadraOspite, string arbitro)
        {
            IdPartita = idPartita;
            SquadraCasa = squadraCasa;
            SquadraOspite = squadraOspite;
            Arbitro = arbitro;
        }

        public int risCasa()
        {
            int ris = 0;
            if (goalList != null)
            {
                foreach (clsGoal g in goalList)
                    if ((!g.Autogoal && g.Marcatore.Squadra == squadraCasa) || (g.Autogoal && g.Marcatore.Squadra == squadraOspite)) ris++;
            }
            return ris;
        }
        public int risTrasferta()
        {
            int ris = 0;
            if (goalList != null)
                foreach (clsGoal g in goalList)
                {
                    if ((!g.Autogoal && g.Marcatore.Squadra == squadraOspite) || (g.Autogoal && g.Marcatore.Squadra == squadraCasa)) ris++;
                }
            return ris;
        }
        public string Vincitrice()
        {
            if (risCasa() > risTrasferta()) return squadraCasa;
            else if (risCasa() < risTrasferta()) return squadraOspite;
            else return "Pareggio";
        }
        public string Risultato()
        {
            return $"{risCasa()} - {risTrasferta()}";
        }
        public string Visualizza()
        {
            return $"ID:{IdPartita} - Casa:{SquadraCasa} - Transferta:{SquadraOspite} - Arbitro:{Arbitro}\n" +
                $"[{string.Join("]\n[", goalList.ConvertAll<string>(g => g.Visuazza()))}]";
        }
    }
}
