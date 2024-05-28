using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igra
{
    public partial class Form2 : Form
    {
        string naziv = "Vase ime";

        public Form2(int highscore)
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 form = new Form1(naziv);
            form.Update();
            form.ShowDialog();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            naziv = name.Text.ToString();
            Form1 form1 = new Form1(naziv);
        }

        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
