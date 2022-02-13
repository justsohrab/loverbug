using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugfathterValentine
{
    public static class LoveManager
    {
        public static void PrintHeartsWithFirstLetterOfThisName(string name)
        {

            string firstLetter = name.Substring(0, 1);

            Console.WriteLine("  " + firstLetter + firstLetter + firstLetter + "   " + firstLetter + firstLetter + firstLetter);
            Console.WriteLine(" " + firstLetter + "   " + firstLetter + " " + firstLetter + "   " + firstLetter);
            Console.WriteLine(firstLetter + "     " + firstLetter + "     " + firstLetter);
            Console.WriteLine(firstLetter + "     " + " " + "     " + firstLetter);
            Console.WriteLine(firstLetter + "     " + " " + "     " + firstLetter);
            Console.WriteLine(" " + firstLetter + "    " + "     " + firstLetter);
            Console.WriteLine("  " + firstLetter + "   " + "    " + firstLetter);
            Console.WriteLine("   " + firstLetter + "  " + "   " + firstLetter);
            Console.WriteLine("    " + firstLetter + "  " + " " + firstLetter);
            Console.WriteLine("     " + firstLetter + " " + firstLetter);
            Console.WriteLine("      " + firstLetter);

        }
    }
}
