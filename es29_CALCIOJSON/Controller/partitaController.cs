using es29_CALCIOJSON.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace es29_CALCIOJSON.Controller
{
    class partitaController
    {
        List<clsPartita> listPartite;
        string pathFile;

        public partitaController(string path)
        {
            listPartite = new List<clsPartita>();
            pathFile = path;
            if (File.Exists(path))
            {
                string jsonDati = File.ReadAllText(path);
                listPartite = JsonConvert.DeserializeObject<List<clsPartita>>(jsonDati);
                //essenziale in quanto jsonconverter restituisce un null se non può parsare nulla
                if (listPartite == null) listPartite = new List<clsPartita>();
            }
            //else File.Create(path);   superficiale
        }
        public List<clsPartita> GET()
        {
            return listPartite;
        }
        public clsPartita GET(int _idPartita)
        {
            return listPartite.Find(p => p.IdPartita == _idPartita);
        }
        public void POST(clsPartita partita)
        {
            listPartite.Add(partita);
            saveData(pathFile, listPartite);
        }
        public void POST(clsGoal goal)
        {
            List<clsGoal> goals = GET(goal.IdPartita).GoalList;
            goal.Numero = goals.Count + 1;
            goals.Add(goal);
            saveData(pathFile, listPartite);
        }
        public void PUT(int id, string squadraCasa, string squadraospite, string arbitro)
        {

            int i = 0;
            bool trovato = false;
            while (i < listPartite.Count && !trovato)
            {
                if (listPartite[i].IdPartita == id)
                {
                    listPartite[i].SquadraCasa = squadraCasa;
                    listPartite[i].SquadraOspite = squadraospite;
                    listPartite[i].Arbitro = arbitro;
                    trovato = true;
                }
                else i++;
            }
            if (trovato)
            {
                saveData(pathFile, listPartite);
            }
        }
        public void DELETE(int id)
        {
            listPartite.RemoveAll(g => g.IdPartita == id);
            saveData(pathFile, listPartite);
        }

        private void saveData(string pathFile, List<clsPartita> list)
        {
            string jsonData = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(pathFile, jsonData);
        }

        internal void DELETE(int idPartita, int numero)
        {
            List<clsGoal> goals = GET(idPartita).GoalList;
            goals.RemoveAt(numero - 1);
            //si procede ad aggiornare la proprietà Numero per i Goal di questo IdPartita
            goals.ForEach(g => g.Numero = goals.IndexOf(g) + 1);


            saveData(pathFile, listPartite);
        }

        internal void PUT(clsGoal goal)
        {
            DELETE(goal.IdPartita, goal.Numero);    //rindondante il salvataggio dei dati
            POST(goal);
            //saveData(pathFile, listPartite); rindondante
        }
    }
}
