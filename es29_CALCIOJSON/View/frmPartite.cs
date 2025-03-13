using es29_CALCIOJSON.Controller;
using es29_CALCIOJSON.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es29_CALCIOJSON.View
{
    public partial class frmPartite: frmMaster
    {
        public frmPartite()
        {
            InitializeComponent();
        }
        partitaController partitaController;
        clsPartita partita;

public string SquadraOspite{get=>txtSquadraOspite.Text;set=>txtSquadraOspite.Text=value;}
public string Arbitro{get=>txtArbitro.Text;set=>txtArbitro.Text=value;}
public string SquadraCasa{get=>txtSquadraCasa.Text;set=>txtSquadraCasa.Text=value;}
public int IdPartita { get => Convert.ToInt32(txtIdPartita.Text); set => txtIdPartita.Text = value.ToString(); }

        private void frmPartite_Load(object sender, EventArgs e)
        {
            partitaController = new partitaController(@"../../JSON/partite.json");
            //a che serve il try catch qui? vorrei toglierlo
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = partitaController.GET();
                if (dgv.Rows.Count == 0)
                    MessageBox.Show("Non ci sono giocatori nel file json");
                dgv.CellClick += Dgv_CellContentClick;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                partita = new clsPartita(IdPartita, SquadraCasa, SquadraOspite, Arbitro, new List<clsGoal>());
                partitaController.POST(partita);

                dgv.DataSource = null;
                dgv.DataSource = partitaController.GET();

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
                partita = partitaController.GET(Convert.ToInt32(dgv.CurrentRow.Cells[3].Value));
                SquadraOspite = partita.SquadraOspite;
                Arbitro = partita.Arbitro;
                SquadraCasa = partita.SquadraCasa;
                IdPartita = partita.IdPartita;

                dgvGoals.DataSource = null;
                dgvGoals.DataSource = partita.GoalList;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                partitaController.PUT(IdPartita, SquadraCasa, SquadraOspite, Arbitro);
                dgv.DataSource = null;
                dgv.DataSource = partitaController.GET();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //vorrei togliere il try-catch ma IdPartita è un input utente
            //nonostante sia preso dalle combobox...
            try
            {
                partitaController.DELETE(IdPartita);
                dgv.DataSource = null;
                dgv.DataSource = partitaController.GET();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
