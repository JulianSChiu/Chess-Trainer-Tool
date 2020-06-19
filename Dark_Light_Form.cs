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
        public int startStop = new int();
        public Dark_Light_Form()
        {
            InitializeComponent();
            startStop = 0;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (startStop == 0)
            {
                button_Start.Text = "Stop";
                label_Coordinate.Text = boardHelper.generateRandomSquare();
                startStop = 1;
            }
            else //startStop == 1
            {
                button_Start.Text = "Start";
                label_Coordinate.Text = "Ready?";
                label_Answer.Text = "Light or Dark?";
                startStop = 0;

            }

        }

        private void button_Light_Click(object sender, EventArgs e)
        {
            if (boardHelper.chessBoard[label_Coordinate.Text] == 1)
            {
                label_Answer.Text = "Wrong!";
            }
            else
            {
                label_Answer.Text = "Correct!";
                label_Coordinate.Text = boardHelper.generateRandomSquare();
            }
        }

        private void button_Dark_Click(object sender, EventArgs e)
        {
            if (boardHelper.chessBoard[label_Coordinate.Text] == 0)
            {
                label_Answer.Text = "Wrong!";
            }
            else
            {
                label_Answer.Text = "Correct!";
                label_Coordinate.Text = boardHelper.generateRandomSquare();
            }
        }
    }
}
