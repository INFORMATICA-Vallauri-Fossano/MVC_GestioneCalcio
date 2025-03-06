using es29_CALCIOJSON.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es29_CALCIOJSON.Controller
{
    class partitaController
    {
        List<clsPartita> listPartite;
        string pathFile;

        public partitaController(string path)
        {
            listPartite= new List<clsPartita>();
            pathFile = path;
            if (File.Exists(path))
            {
                string jsonDati = File.ReadAllText(path);
                listPartite= JsonConvert.DeserializeObject<List<clsPartita>>(jsonDati);
                //essenziale in quanto jsonconverter restituisce un null se non può parsare nulla
                if (listPartite== null) listPartite= new List<clsPartita>();
            }
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
        public void PUT(int id,string squadraCasa,string squadraospite,string arbitro)
        {

            int i = 0;
            bool trovato = false;
            while (i < listPartite.Count && !trovato)
            {
                if (listPartite[i].IdPartita== id)
                {
                    listPartite[i].SquadraCasa= squadraCasa;
                    listPartite[i].SquadraOspite= squadraospite;
                    listPartite[i].Arbitro= arbitro;
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
            listPartite.RemoveAll(g => g.IdPartita== id);
            saveData(pathFile, listPartite);
        }

        private void saveData(string pathFile, List<clsPartita> lstGiocatori)
        {
            string jsonData = JsonConvert.SerializeObject(lstGiocatori, Formatting.Indented);
            File.WriteAllText(pathFile, jsonData);
        }
    }
}
