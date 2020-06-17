using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Trainer_Tool
{
    public class boardHelper
    {
        public static string[] allFile = { "a", "b", "c", "d", "e", "f", "g", "h" };
        public static string[] allRank = { "1", "2", "3", "4", "5", "6", "7", "8" };

        public static string[] createBoard()
        {
            string[] myBoard = new string[64];

            for (int i = 0; i <8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    myBoard.Append(allFile[i] + allRank[j]);
                }
            }

            return myBoard;
        }

        public static string generateRandomSquare()
        {
            Random rnd = new Random();
            int rndFile = rnd.Next(0, 8);
            int rndRank = rnd.Next(0, 8);

            return allFile[rndFile] + allRank[rndRank];
        }
        public static Boolean verifyColor()
        {
            Boolean TorF = new bool();

            

            return TorF;
        }
    }
}
