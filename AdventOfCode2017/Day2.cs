using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Day2 : ISolver
    {
        public string Solve( string input )
        {
            var lines = input.Split('\n')
                .Select( x => x.Split( '\t' ) )
                .Select( arr => arr.Select( str => Convert.ToInt32( str ) ) );

            var sum = 0;
            foreach (var intarr in lines)
            {
                sum += intarr.Max() - intarr.Min();
            }

            return sum.ToString();
        }
    }
}
