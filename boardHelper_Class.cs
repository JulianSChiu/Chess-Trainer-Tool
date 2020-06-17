using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Trainer_Tool
{
    public class boardHelper
    {
        public static string[] allFile = { "a", "b", "c", "d", "e", "f", "g", "h" };
        public static string[] allRank = { "1", "2", "3", "4", "5", "6", "7", "8" };

        public static string generateRandomSquare()
        {
            Random rnd = new Random();
            int rndFile = rnd.Next(0, 8);
            int rndRank = rnd.Next(0, 8);

            return allFile[rndFile] + allRank[rndRank];
        }
    }
}
