using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
        public int correctPoints = new int();
        public int wrongPoints = new int();
        public Dark_Light_Form()
        {
            InitializeComponent();
            startStop = 0;
            correctPoints = 0;
            wrongPoints = 0;
        }

        //start stop the game. 
        private void button_Start_Click(object sender, EventArgs e)
        {
            //Start new game until stop is pressed. (Reset points on Start)
            if (startStop == 0)
            {
                button_Start.Text = "Stop";
                label_Coordinate.Text = boardHelper.generateRandomSquare();
                startStop = 1;
                correctPoints = 0;
                wrongPoints = 0;
                updatePoints();
                button_Dark.Enabled = true;
                button_Light.Enabled = true;
            }
            //Stop the game. light and dark buttons disabled
            else //startStop == 1
            {
                button_Start.Text = "Start";
                label_Coordinate.Text = "Ready?";
                label_Answer.Text = "Light or Dark?";
                startStop = 0;
                button_Dark.Enabled = false;
                button_Light.Enabled = false;
            }

        }

        private void button_Light_Click(object sender, EventArgs e)
        {
            if (boardHelper.chessBoard[label_Coordinate.Text] == 1)
            {
                label_Answer.Text = "Wrong!";
                wrongPoints++;
            }
            else
            {
                label_Answer.Text = "Correct!";
                correctPoints++;
            }
            updatePoints();
            label_Coordinate.Text = boardHelper.generateRandomSquare();
        }

        private void button_Dark_Click(object sender, EventArgs e)
        {
            if (boardHelper.chessBoard[label_Coordinate.Text] == 0)
            {
                label_Answer.Text = "Wrong!";
                wrongPoints++;
            }
            else
            {
                label_Answer.Text = "Correct!";
                correctPoints++;
            }
            updatePoints();
            label_Coordinate.Text = boardHelper.generateRandomSquare();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            correctPoints = 0;
            wrongPoints = 0;
            updatePoints();
        }

        private void updatePoints()
        {
            label_CorrectCounter.Text = correctPoints.ToString();
            label_WrongCounter.Text = wrongPoints.ToString();
        }

    }
}
