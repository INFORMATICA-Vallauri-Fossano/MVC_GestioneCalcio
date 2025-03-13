using es29_CALCIOJSON.Controller;
using es29_CALCIOJSON.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace es29_CALCIOJSON.View
{
    public partial class frmGoal : frmMaster
    {
        public frmGoal()
        {
            InitializeComponent();
        }
        goalController goalController;
        partitaController partitaController;
        giocatoreController giocatoreController;
        //property
        public string Marcatore { get => cmbMarcatore.Text; set => cmbMarcatore.Text = value; }
        public string Minuto { get => txtMinuto.Text; set => txtMinuto.Text = value; }
        public bool Autogoal { get => chkAutoGoal.Checked; set => chkAutoGoal.Checked = value; }
        public int IdPartita
        {
            get => Convert.ToInt32(cmbIdPartita.Text); set
            {
                cmbIdPartita.Text = value.ToString();
            }
        }
        public int Numero { get => Convert.ToInt32(cmbNumero.Text); set => cmbNumero.Text = value.ToString(); }

        private void frmGoal_Load(object sender, EventArgs e)
        {
            goalController = new goalController(@"../../JSON/giocatori.json", @"../../JSON/partite.json");
            partitaController = new partitaController(@"../../JSON/partite.json");
            giocatoreController = new giocatoreController(@"../../JSON/giocatori.json");
            //qui non inserirò il try-catch
            aggiornaDGVGoal();
            dgvPartite.DataSource = null;
            dgvPartite.DataSource = partitaController.GET();

            cmbMarcatore.DataSource = null;
            cmbMarcatore.DataSource = giocatoreController.GET().ConvertAll<string>(g => g.Nome);

            cmbIdPartita.DataSource = null;
            cmbIdPartita.DataSource = partitaController.GET().ConvertAll<int>(p => p.IdPartita);

            aggiornaCMBNumero();
            dgv.CellClick += Dgv_CellContentClick;


        }

        public void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow.Index != -1)
            {
                clsGoal goal = goalController.GET(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value), Convert.ToInt32(dgv.CurrentRow.Cells[1].Value));
                Marcatore = goal.Marcatore.Nome;
                Minuto = goal.Minuto;
                Autogoal = goal.Autogoal;
                IdPartita = goal.IdPartita;
                Numero = goal.Numero;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                clsGoal goal = new clsGoal(IdPartita, giocatoreController.GET(Marcatore), Minuto, Autogoal);
                goalController.POST(goal);

                aggiornaDGVGoal();
                aggiornaCMBNumero();

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
                goalController.DELETE(IdPartita, Numero);

                aggiornaDGVGoal();
                aggiornaCMBNumero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                goalController.PUT(IdPartita, Numero, Marcatore, Minuto, Autogoal);
                aggiornaDGVGoal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIdPartita_SelectedIndexChanged(object sender, EventArgs e)
        {
            aggiornaCMBNumero();
        }
        private void aggiornaDGVGoal()
        {
            dgv.DataSource = null;
            dgv.DataSource = goalController.GET();
        }

        private void aggiornaCMBNumero()
        {
            cmbNumero.DataSource = null;
            cmbNumero.DataSource = partitaController.GET(IdPartita).GoalList.ConvertAll<int>(g => g.Numero);
        }
    }
}
