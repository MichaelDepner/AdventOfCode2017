using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main( string[] args )
        {
            var day1Input = Properties.Resources.Day1;
            //Console.WriteLine(day1Input);
            var day1 = new Day1();
            Console.WriteLine( day1.Solve( day1Input ) ); 

            var day1_2 = new Day1_2();
            Console.WriteLine( day1_2.Solve( day1Input ) );

            var day2Input = Properties.Resources.Day2;
            var day2 = new Day2();
            Console.WriteLine( day2.Solve( day2Input ) );

            Console.ReadKey();
        }
    }
}
