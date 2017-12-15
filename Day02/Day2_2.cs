using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace Day02
{
    class Day2_2 : ISolver

    {
        public string PuzzleName => "Day 2 Part 2";

        public string Solve(string input)
        {
            var lines = input.Split('\n')
                .Select(x => x.Split('\t'))
                .Select(arr => arr.Select(str => Convert.ToInt32(str)));

            var sum = 0;
            foreach (var intEnumerable in lines)
            {
                List<int> intList = intEnumerable.ToList();
                foreach (var i in intEnumerable)
                {
                    int divisionFriend = 0;
                    divisionFriend = intList.Find(x => (x % i == 0) && (x != i));
                    //Console.WriteLine("Found " + divisionFriend + " for i=" + i);
                    if (divisionFriend != 0)
                    {
                        sum += (divisionFriend / i);
                    }
                }
            }

            return sum.ToString();
        }
    }
}
