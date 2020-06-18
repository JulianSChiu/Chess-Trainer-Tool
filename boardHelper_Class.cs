using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Chess_Trainer_Tool
{
    public class boardHelper
    {
        public static string[] allFile = { "a", "b", "c", "d", "e", "f", "g", "h" };
        public static string[] allRank = { "1", "2", "3", "4", "5", "6", "7", "8" };
        /*public static string[] chessBoard = {"a1", "a2", "a3", "a4", "a5", "a6", "a7", "a8",
                                             "b1", "b2", "b3", "b4", "b5", "b6", "b7", "b8",
                                             "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8",
                                             "d1", "d2", "d3", "d4", "d5", "d6", "d7", "d8",
                                             "e1", "e2", "e3", "e4", "e5", "e6", "e7", "e8",
                                             "f1", "f2", "f3", "f4", "f5", "f6", "f7", "f8",
                                             "g1", "g2", "g3", "g4", "g5", "g6", "g7", "g8",
                                             "h1", "h2", "h3", "h4", "h5", "h6", "h7", "h8"
        };*/

        // 0 for light and 1 for dark squares
        public static Dictionary<string, int> chessBoard = new Dictionary<string, int>()
        {
            {"a1", 1}, {"a2",0}, {"a3", 1}, {"a4", 0}, {"a5", 1}, {"a6", 0}, {"a7", 1}, {"a8", 0},
            {"b1", 0}, {"b2",1}, {"b3", 0}, {"b4", 1}, {"b5", 0}, {"b6", 1}, {"b7", 0}, {"b8", 1},
            {"c1", 1}, {"c2",0}, {"c3", 1}, {"c4", 0}, {"c5", 1}, {"c6", 0}, {"c7", 1}, {"c8", 0},
            {"d1", 0}, {"d2",1}, {"d3", 0}, {"d4", 1}, {"d5", 0}, {"d6", 1}, {"d7", 0}, {"d8", 1},
            {"e1", 1}, {"e2",0}, {"e3", 1}, {"e4", 0}, {"e5", 1}, {"e6", 0}, {"e7", 1}, {"e8", 0},
            {"f1", 0}, {"f2",1}, {"f3", 0}, {"f4", 1}, {"f5", 0}, {"f6", 1}, {"f7", 0}, {"f8", 1},
            {"g1", 1}, {"g2",0}, {"g3", 1}, {"g4", 0}, {"g5", 1}, {"g6", 0}, {"g7", 1}, {"g8", 0},
            {"h1", 0}, {"h2",1}, {"h3", 0}, {"h4", 1}, {"h5", 0}, {"h6", 1}, {"h7", 0}, {"h8", 1},
        };

        // Needs rework
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
            // string[] board = createBoard();

            List<string> keyList = new List<string>(chessBoard.Keys);
            Random rnd = new Random();
            string rndKey = keyList[rnd.Next(keyList.Count)];

            return rndKey;
        }
        public static Boolean verifyColor()
        {
            Boolean TorF = new bool();

            

            return TorF;
        }
    }
}
