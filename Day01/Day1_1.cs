using System;
using System.Linq;
using Utils;

namespace Day01
{
    public class Day1_1 : ISolver
    {
        public string PuzzleName => "Day 1 Part 1";

        public string Solve(string input)
        {
            var list = input.ToCharArray()
                .Select(x => Convert.ToInt32(Char.GetNumericValue(x)));

            int sum = 0;
            var previous = list.Last();
            foreach (var element in list)
            {
                if (element == previous)
                {
                    sum += element;
                }
                previous = element;
            }
            return sum.ToString();
        }
    }
}
