using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es29_CALCIOJSON.Models
{
    class clsGiocatore
    {
        private string nome;
        private static string[] ruoli = { "PORTIERE", "DIFENSORE","CENTROCAMPISTA", "ATTACCANTE" };
        private string ruolo;
        private string squadra;
        private int numeroMaglia;

        public string Nome { get => nome; set
            {
                if (value.Trim().Length < 2) throw new Exception("Nome non valido, almeno 2 caratteri");
                else nome = value;
            }
        }
        //combobox
        public string Ruolo { get => ruolo; set {
                if (!Array.Exists(ruoli, ruo => ruo == value)) throw new Exception("Ruolo non Valido, " + string.Join("-", ruoli));
                else ruolo = value;
            } }
        public string NumeroMaglia { get=>numeroMaglia.ToString(); set
            {
                if (!int.TryParse(value, out numeroMaglia) || numeroMaglia <= 0) throw new Exception("numero non valido, intero positivo");
            }
        }
        public string Squadra { get => squadra; set
            {
                if (value.Trim().Length < 2) throw new Exception("Squadra non valida, almeno 2 caratteri");
                else squadra = value;
        }
        }

        public static string[] Ruoli { get => ruoli; }

        public clsGiocatore(string _nome,string _ruolo, string _squadra,string _numeroMaglia)
        {
            Nome = _nome;
            Ruolo = _ruolo;
            Squadra = _squadra;
            NumeroMaglia = _numeroMaglia;
        }
        public clsGiocatore() { }
        //METODI
        public string Visualizza()
        {
            return $"{Nome} - {Ruolo} - {Squadra} - {NumeroMaglia}";
        }
    }
}
