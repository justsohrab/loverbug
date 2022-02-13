using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BugfathterValentine
{
    class Program
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        static void Main(string[] args)
        {

            
             DeleteMenu(GetSystemMenu(GetConsoleWindow(), false),SC_CLOSE, MF_BYCOMMAND);
            //esmesho migirim
            string name = GetTheName();

            //vaghti be inja beresim dige esmo darim
            LoveManager.PrintHeartsWithFirstLetterOfThisName(name);

            //eshghamo behesh tozih bede
            DescribeMyLoveToThisName(name);

            //check mikone bebine hanuz dusesh darim ya na
            CheckIfHimOrHerLovesMeBack();

            Console.WriteLine("Mamnun az hamrahi shoma, narmafzar pas az 8 saniye khodkar baste khahad shod ;)");
            Thread.Sleep(8000);
        }

        private static void CheckIfHimOrHerLovesMeBack()
        {
            string javab = Console.ReadLine().ToLower();
            while (javab != "bale")
            {
                Console.WriteLine("Javab sahih nist!");
                Console.WriteLine($"----------------------------");
                Console.WriteLine($"Dar soorati ke dustam darid kalameye bale var dar gheyre in surat antegrale 81452/87log 10 2 ra vared konid:");
                javab = Console.ReadLine().ToLower();
            }
        }

        private static void DescribeMyLoveToThisName(string name)
        {
            Console.WriteLine($"Dooset daram {name}!");

            Console.WriteLine($"Toam doosam dari?");
            Console.WriteLine($"----------------------------");
            Console.WriteLine($"Dar soorati ke dustam darid kalameye bale var dar gheyre in surat antegrale 81452/87log 10 2 ra vared konid:");
        }

        private static string GetTheName()
        {
            //inja esmesho azash mikhaym ke vared kone
            Console.WriteLine("Lotfan esmeto vared kon bebin chi mishe:");
            Console.WriteLine("------------------------------------------");

            //inja esmesho migirimo o mirizim tuye moteghayer name
            string name = Console.ReadLine();

            //migim ta vaghti dorost vared nakarde hey azash beporse
            while (name.Length == 0)
            {
                Console.WriteLine("Lotfan esmeto vared kon bebin chi mishe:");
                Console.WriteLine("------------------------------------------");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}
