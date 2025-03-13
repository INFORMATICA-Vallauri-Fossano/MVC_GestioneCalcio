using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using es29_CALCIOJSON.Models;
using es29_CALCIOJSON.Controller;
using System.Runtime.InteropServices;

namespace es29_CALCIOJSON.View
{
    public partial class frmGiocatori: frmMaster
    {
        public frmGiocatori()
        {
            InitializeComponent();
        }
        //PROPERTIES DEL GIOCATORE DINAMICHE
        public string Nome
        {
            get => txtNome.Text;
            set => txtNome.Text = value.Trim();
        }
        public string Ruolo
        {
            get => cmbRuolo.Text;
            set
            {
                cmbRuolo.SelectedIndex = cmbRuolo.FindStringExact(value.Trim().ToUpper());
            }
        }
        public string Squadra
        {
            get => txtSquadra.Text;
            set => txtSquadra.Text = value.Trim();
        }
        public string NumeroMaglia
        {
            get => txtNumeroMaglia.Text;
            set => txtNumeroMaglia.Text = value.Trim();
        }
        clsGiocatore giocatore;
        giocatoreController giocatoreController;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                giocatore = new clsGiocatore(Nome, Ruolo, Squadra, NumeroMaglia);
                giocatoreController.POST(giocatore);

                dgv.DataSource = null;
                dgv.DataSource = giocatoreController.GET();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGiocatori_Load(object sender, EventArgs e)
        {
            giocatoreController = new giocatoreController(@"../../JSON/giocatori.json");
            //pure qua il try catch noon si potrebbe evitare?
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = giocatoreController.GET();
                if (dgv.Rows.Count == 0)
                    MessageBox.Show("Non ci sono giocatori nel file json");
                dgv.CellClick += Dgv_CellContentClick;
                cmbRuolo.DataSource = null;
                cmbRuolo.DataSource = clsGiocatore.Ruoli;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow.Index != -1)
            {
                //giocatore = giocatoreController.GET(dgv.CurrentRow.Cells[0].Value.ToString());
                giocatore = giocatoreController.GET(dgv.CurrentRow.Index);
                Nome = giocatore.Nome;
                Squadra = giocatore.Squadra;
                NumeroMaglia = giocatore.NumeroMaglia;
                Ruolo = giocatore.Ruolo;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
            giocatoreController.PUT(Nome, Ruolo,Squadra, NumeroMaglia);
                dgv.DataSource = null;
                dgv.DataSource = giocatoreController.GET();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                giocatoreController.DELETE(Nome);
                dgv.DataSource = null;
                dgv.DataSource = giocatoreController.GET();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
