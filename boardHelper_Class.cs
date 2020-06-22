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
        // manually creating a dictionary for all squares with color values
        // color values: 0 for light and 1 for dark squares
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

        // function to generate random square from dictionary
        public static string generateRandomSquare()
        {
            // taking all the keys (squares) from chessBoard
            List<string> keyList = new List<string>(chessBoard.Keys);
            // initialize random object
            Random rnd = new Random();
            // generate random key from key list
            string rndKey = keyList[rnd.Next(keyList.Count)];

            return rndKey;
        }
    }
}
