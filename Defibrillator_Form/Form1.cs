using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Defibrillator_Form
{
    public partial class Defibrillator : Form
    {
        static List<Keszulek> adatok = new List<Keszulek>();
        public Defibrillator()
        {
            InitializeComponent();
            lbl_X.Text = "X Koordináta: ";
            lbl_Y.Text = "Y Koordináta: ";
            btn_Adatok.Enabled = false;
            btn_Adatok.Enabled = true;
        }

        private void btn_Ujadat_Click(object sender, EventArgs e)
        {
            lbKiir.Items.Clear();
            tb_X.Text = "";
            tb_Y.Text = "";
            MessageBox.Show("Az adatok törlésre kerültek");
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Adatok_Click(object sender, EventArgs e)
        {
            StreamReader olvas = new StreamReader("data.csv");
            olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                string[] a = olvas.ReadLine().Split(';');
                adatok.Add(new Keszulek(
                    int.Parse(a[0]),
                    a[1],
                    double.Parse(a[2]),
                    double.Parse(a[3]),
                    a[4],
                    a[5]
                    ));
            }
            olvas.Close();
            Console.WriteLine();
        }
    }
}
