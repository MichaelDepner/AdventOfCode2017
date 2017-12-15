using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace Day01
{
    class Day1_2 : ISolver
    {
        public string PuzzleName => "Day 1 Part 2";

        public string Solve(string input)
        {
            var list = input.ToCharArray()
               .Select(x => Convert.ToInt32(Char.GetNumericValue(x)));

            int sum = 0;
            int pos = 0;
            var previous = GetHalfwayPosition(0, list.Count());
            foreach (var element in list)
            {
                if (element == list.ElementAt(GetHalfwayPosition(pos, list.Count())))
                {
                    sum += element;
                }
                previous = element;
                pos++;
            }
            return sum.ToString();
        }

        int GetHalfwayPosition(int initialPosition, int listLength)
        {
            int steps = listLength / 2;
            int total = initialPosition + steps;
            return (total < listLength) ? total : (total % listLength);
        }
    }
}
