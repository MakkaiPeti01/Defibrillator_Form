using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defibrillator_Form
{
    public partial class Defibrillator : Form
    {
        public Defibrillator()
        {
            InitializeComponent();
            lbl_X.Text = "X Koordináta: ";
            lbl_Y.Text = "Y Koordináta: ";
            btn_Adatok.Enabled = false;
        }

        private void btn_Ujadat_Click(object sender, EventArgs e)
        {
            lbKiir.Items.Clear();
            tb_X.Text = "";
            tb_Y.Text = "";
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
