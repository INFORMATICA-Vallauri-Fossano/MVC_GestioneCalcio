using es29_CALCIOJSON.Controller;
using es29_CALCIOJSON.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es29_CALCIOJSON.View
{
    public partial class frmGoal: frmMaster
    {
        public frmGoal()
        {
            InitializeComponent();
        }
        goalController goalController;
        private void btnAggiungiGoal_Click(object sender, EventArgs e)
        {
            if (dgvGiocatori.SelectedRows.Count > 0)
            {
                List<clsGoal> scelta = new List<clsGoal>();
                for (int i = 0; i < dgvGiocatori.SelectedRows.Count; i++)
                {
                    DataGridViewCellCollection cells = dgvGiocatori.SelectedRows[i].Cells;
                    scelta.Add(new clsGoal(cells[0], cells[1], cells[2], cells[3]));
                }
            }
            else MessageBox.Show("Seleziona almeno un goal da aggiungere nella lista a destra");


        }

        private void frmGoal_Load(object sender, EventArgs e)
        {
            goalController = new goalController(@"../../JSON/giocatori.json", @"../../JSON/partite.json");

        }
    }
}
