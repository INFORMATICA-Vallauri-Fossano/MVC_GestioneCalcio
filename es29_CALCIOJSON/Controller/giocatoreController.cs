using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;
using es29_CALCIOJSON.Models;
using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace es29_CALCIOJSON.Controller
{
    class giocatoreController
    {
        public clsGiocatore recGiocatore;
        public List<clsGiocatore> lstGiocatori;
        string pathFile;
        public giocatoreController(string path)
        {
            lstGiocatori = new List<clsGiocatore>();
            pathFile = path;
            if (File.Exists(path))
            {
                string jsonDati = File.ReadAllText(path);
                lstGiocatori = JsonConvert.DeserializeObject<List<clsGiocatore>>(jsonDati);
                //essenziale in quanto jsonconverter restituisce un null se non può parsare nulla
                if (lstGiocatori == null) lstGiocatori = new List<clsGiocatore>();
            }
            //else File.Create(path);   superficiale
        }
        //CRUD
        //CREATE - READ- UPDATE - DELETE
        //sono 4 operazioni base che si possono eseguire sui dati memorizzati sul database
        //o su altri sistemigestione dati
        /// <summary>
        /// restituisce una lista con tutti i giocatori presenti nel file json
        /// </summary>
        /// <returns></returns>
        public List<clsGiocatore> GET()
        {
            return lstGiocatori;
        }

        /// <summary>
        /// READ
        /// restituisce un giocatore della lista
        /// </summary>
        /// <param name="nome">nome del giocatore da cercare</param>
        /// <returns></returns>
        public clsGiocatore GET(string nome)
        {
            recGiocatore = lstGiocatori.Find(g => g.Nome == nome);
            return recGiocatore;
        }
        public clsGiocatore GET(int index)
        {
            recGiocatore = lstGiocatori[index];
            return recGiocatore;
        }
        /// <summary>
        /// CREATE
        /// </summary>
        /// <param name="giocatore"></param>
        public void POST(clsGiocatore giocatore)
        {
            lstGiocatori.Add(giocatore);
            saveData(pathFile,lstGiocatori);
        }
        /// <summary>
        /// UPDATE
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="ruolo"></param>
        /// <param name="numero"></param>
        public void PUT(string nome,string ruolo,string squadra,string numero)
        {
            int i = 0;
            bool trovato = false;
            while (i < lstGiocatori.Count && !trovato)
            {
                if (lstGiocatori[i].Nome == nome)
                {
                    lstGiocatori[i].Ruolo = ruolo;
                    lstGiocatori[i].NumeroMaglia = numero;
                    lstGiocatori[i].Squadra = squadra;
                    trovato = true;
                }
                else i++;
            }
            if (trovato)
            {
                saveData(pathFile,lstGiocatori);
            }
        }
        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="nome"></param>
        public void DELETE(string nome)
        {
            lstGiocatori.RemoveAll(g => g.Nome == nome);
            saveData(pathFile, lstGiocatori);
        }

        private void saveData(string pathFile,List<clsGiocatore> lstGiocatori)
        {
            string jsonData = JsonConvert.SerializeObject(lstGiocatori,Formatting.Indented);
            File.WriteAllText(pathFile,jsonData);
        }
    }
}
