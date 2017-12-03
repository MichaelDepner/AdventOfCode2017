using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    public class Day1 : ISolver
    {
        public string Solve( string input )
        {
            var list = input.ToCharArray()
                .Select( x => Convert.ToInt32( Char.GetNumericValue( x ) ) );

            int sum = 0;
            var previous = list.Last();
            foreach (var element in list)
            {
                if ( element == previous )
                {
                    sum += element;
                }
                previous = element;
            }
            return sum.ToString();
        }
    }
}
