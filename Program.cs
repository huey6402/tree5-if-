using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("    *    ");
               Console.WriteLine("   ***   ");
               Console.WriteLine("  *****  ");
               Console.WriteLine(" ******* ");
               Console.WriteLine("*********"); */
            int a , b ;
            string x , z ;
            a = 1 ;
            x = "*" ;
            z = " " ;
            while (a <= 5) 
            {
                {
                    if (a < 5) { Console.Write(z); }
                    if (a < 4) { Console.Write(z); }
                    if (a < 3) { Console.Write(z); }
                    if (a < 2) { Console.Write(z); }
                    Console.Write(x);
                    if (a > 1) { Console.Write(x+x); }
                    if (a > 2) { Console.Write(x+x); }
                    if (a > 3) { Console.Write(x+x); }
                    if (a > 4) { Console.Write(x+x); }
                    /*if (a < 2) { Console.Write(z); }
                    if (a < 3) { Console.Write(z); }
                    if (a < 4) { Console.Write(z); }
                    if (a < 5) { Console.Write(z); }*/
                }
                Console.WriteLine("");
                a = a + 1 ; 
            }
            //Console.WriteLine("END");
        }
    }
    
}
        