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
    public partial class Dark_Light_Form : Form
    {
        public Dark_Light_Form()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            string Coordinate = boardHelper.generateRandomSquare();
            label_Coordinate.Text = Coordinate;

        }

        private void button_Light_Click(object sender, EventArgs e)
        {

        }

        private void button_Dark_Click(object sender, EventArgs e)
        {

        }
    }
}
