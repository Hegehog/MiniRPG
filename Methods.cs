using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniRPG
{
    partial class Program
    {
        private static void WL()
        {
            Console.WriteLine();
        } //WriteLine with no arguments
        private static void WL(string p)
        {
            Console.WriteLine(p);
        } //WriteLine
        private static void W(string p)
        {
            Console.Write(p);
        } //Write
        private static string Inp()
        {
            return Console.ReadLine();
        }
    }
}
