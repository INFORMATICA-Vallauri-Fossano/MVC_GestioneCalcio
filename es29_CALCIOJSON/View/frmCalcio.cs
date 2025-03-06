using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using es29_CALCIOJSON.View;

namespace es29_CALCIOJSON
{
    public partial class frmCalcio: Form
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
