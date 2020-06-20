using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Trainer_Tool
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void guessTheColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DL = new Dark_Light_Form();
            DL.Show();
            this.Hide();
        }

        private void chessBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CB = new chessBoardForm();
            CB.Show();
            this.Hide();
        }
    }
}
