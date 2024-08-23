using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lithium.System.Logger
{
    public abstract class LITLogger
    {
        public static void Info(string message)
        {
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("INFO");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" ] ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public static void Fine(string message)
        {
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("FINE");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" ] ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public static void Warning(string message)
        {
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WARN");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" ] ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public static void Error(string message)
        {
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" ] ");
            Console.ResetColor();
            Console.WriteLine(message);
        }
    }
}
