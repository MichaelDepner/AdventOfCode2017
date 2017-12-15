using System;
using System.Linq;
using Utils;

namespace Day02
{
    public class Day2_1 : ISolver
    {
        public string PuzzleName => "Day 2 Part 1";

        public string Solve(string input)
        {
            var lines = input.Split('\n')
                .Select(x => x.Split('\t'))
                .Select(arr => arr.Select(str => Convert.ToInt32(str)));

            var sum = 0;
            foreach (var intarr in lines)
            {
                sum += intarr.Max() - intarr.Min();
            }

            return sum.ToString();
        }
    }
}
