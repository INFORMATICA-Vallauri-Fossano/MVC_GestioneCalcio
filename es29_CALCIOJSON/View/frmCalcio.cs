//
using es29_CALCIOJSON.View;
using System;
using System.Windows.Forms;

namespace es29_CALCIOJSON
{
    public partial class frmCalcio : Form
    {
        public frmCalcio()
        {
            InitializeComponent();
        }

        private void btnGiocatori_Click(object sender, EventArgs e)
        {
            frmGiocatori frm = new frmGiocatori();
            frm.ShowDialog();
        }

        private void btnPartite_Click(object sender, EventArgs e)
        {
            frmPartite frm = new frmPartite();
            frm.ShowDialog();

        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            frmGoal frm = new frmGoal();
            frm.ShowDialog();

        }
    }
}
