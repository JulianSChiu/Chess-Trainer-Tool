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
    public partial class chessBoardForm : Form
    {
        public chessBoardForm()
        {
            InitializeComponent();

        }
        // class member array of Panels to track chessboard tiles
        private Panel[,] _chessBoardPanels;

        // event handler of Form Load... init things here
        private void Form_Load(object sender, EventArgs e)
        {
            const int tileSize = 40;
            const int gridSize = 8;
            var clr1 = Color.DarkGray;
            var clr2 = Color.White;

            // initialize the "chess board"
            _chessBoardPanels = new Panel[gridSize, gridSize];

            // double for loop to handle all rows and columns
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    // create new Panel control which will be one 
                    // chess board tile
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n + 50, tileSize * m + 50)
                    };

                    // add to Form's Controls so that they show up
                    Controls.Add(newPanel);

                    // add to our 2d array of panels for future use
                    _chessBoardPanels[n, m] = newPanel;

                    // color the backgrounds
                    if (n % 2 == 0)
                        newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;

                    //set image layout to stretch for all squares
                    _chessBoardPanels[n, m].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }

            //initiate starting position for chess pieces
            startPosition();
            
        }

        //chess pieces starting positions from whiteside
        private void startPosition()
        {
            //black

            //for black pawns all files on rank 7
            for (int n = 0; n < 8; n++)
            {
                _chessBoardPanels[n, 1].BackgroundImage = Properties.Resources.black_pawn;
            }

            //rook
            _chessBoardPanels[0, 0].BackgroundImage = Properties.Resources.black_rook;
            _chessBoardPanels[7, 0].BackgroundImage = Properties.Resources.black_rook;

            //knight
            _chessBoardPanels[1, 0].BackgroundImage = Properties.Resources.black_knight;          
            _chessBoardPanels[6, 0].BackgroundImage = Properties.Resources.black_knight;

            //bishop
            _chessBoardPanels[2, 0].BackgroundImage = Properties.Resources.black_bishop;
            _chessBoardPanels[5, 0].BackgroundImage = Properties.Resources.black_bishop;

            //queen
            _chessBoardPanels[3, 0].BackgroundImage = Properties.Resources.black_queen;

            //king
            _chessBoardPanels[4, 0].BackgroundImage = Properties.Resources.black_king;


            //white

            //for white pawns all files on rank 2
            for (int n = 0; n < 8; n++)
            {
                _chessBoardPanels[n, 6].BackgroundImage = Properties.Resources.white_pawn;
            }
            //rook
            _chessBoardPanels[0, 7].BackgroundImage = Properties.Resources.white_rook;
            _chessBoardPanels[7, 7].BackgroundImage = Properties.Resources.white_rook;

            //knight
            _chessBoardPanels[1, 7].BackgroundImage = Properties.Resources.white_knight;
            _chessBoardPanels[6, 7].BackgroundImage = Properties.Resources.white_knight;

            //bishop
            _chessBoardPanels[2, 7].BackgroundImage = Properties.Resources.white_bishop;
            _chessBoardPanels[5, 7].BackgroundImage = Properties.Resources.white_bishop;

            //queen
            _chessBoardPanels[3, 7].BackgroundImage = Properties.Resources.white_queen;

            //king
            _chessBoardPanels[4, 7].BackgroundImage = Properties.Resources.white_king;
        }
    }
       
}
