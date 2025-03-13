using es29_CALCIOJSON.Models;
using System.Collections.Generic;
using System.Linq;

namespace es29_CALCIOJSON.Controller
{
    class goalController
    {
        giocatoreController giocatoreController;
        partitaController partitaController;
        List<clsGoal> goalList;
        public goalController(string pathGiocatori, string pathPartite)
        {
            giocatoreController = new giocatoreController(pathGiocatori);
            partitaController = new partitaController(pathPartite);
            goalList = partitaController.GET().SelectMany<clsPartita, clsGoal>((p, index) => p.GoalList).ToList();
        }
        public List<clsGoal> GET()
        {
            return goalList;
        }
        public List<clsGoal> GET(int idPartita)
        {
            return partitaController.GET(idPartita).GoalList;
        }
        public List<clsGoal> GET(string nomeGiocatore)
        {
            return goalList.Where(g => g.Marcatore.Nome == nomeGiocatore).ToList();
        }
        public clsGoal GET(int idPartita, int numero)
        {
            return goalList.Find(g => g.IdPartita == idPartita && g.Numero == numero);
        }
        public void POST(clsGoal goal)
        {
            goalList.Add(goal);
            partitaController.POST(goal);
        }
        public void DELETE(int idPartita, int numero)
        {
            goalList.Remove(goalList.Find(g => g.IdPartita == idPartita && g.Numero == numero));
            partitaController.DELETE(idPartita, numero);
        }
        public void PUT(int idPartita, int numero, /*identificatore del giocatore*/string nomeGiocatore, string minuto, bool autogol)
        {
            clsGoal goal = goalList.Find(g => g.IdPartita == idPartita && g.Numero == numero);
            goal.Marcatore = giocatoreController.GET(nomeGiocatore);
            goal.Minuto = minuto;
            goal.Autogoal = autogol;
            partitaController.PUT(goal);
        }
    }
}
