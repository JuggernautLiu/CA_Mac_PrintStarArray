using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_Mac_PrintStarArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 5;
            // Test if input arguments were supplied:
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a numeric argument.");
                System.Console.WriteLine("Usage: Main.exe <num>");
                return;
            }
            
            bool bPassArgument= int.TryParse(args[0],out count);
            if (bPassArgument == false)
            {
                System.Console.WriteLine("Please enter a numeric argument.");
                System.Console.WriteLine("Usage: Main.exe <num>");
                return;
            }

            string[,] arrays = new string[count,count];
            PrintStarProcessor star = new PrintStarProcessor();
            star.Init(ref arrays,count);
            star.GenerateStar(ref arrays);
            string str = star.GetPrintString(arrays);
            Console.Write(str);
        }
    }
}
