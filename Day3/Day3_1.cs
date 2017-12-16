using System;
using Utils;

namespace Day3
{
    public class Day3_1 : ISolver
    {
        public string PuzzleName => "Day 3 Part 1";

        public string Solve(string input)
        {
            int goal = Convert.ToInt32(input);
            var coords = FindCoordsIterative(goal);
            var manhattanDistance = Math.Abs(coords.Item1) + Math.Abs(coords.Item2);
            return manhattanDistance.ToString();
        }

        private Tuple<int, int> FindCoordsIterative(int goal)
        {
            int x = 0;
            int y = 0;
            int currentNumber = 1;
            int directionSwitch = 1;
            int currentDistance = 0;
            int maxDistance = 1;

            while ( currentNumber != goal )
            {
                if (currentDistance == maxDistance)
                {
                    switch (directionSwitch)
                    {
                        case 1:
                            currentDistance = 0;
                            directionSwitch++;
                            break;
                        case 2:
                            currentDistance = 0;
                            directionSwitch++;
                            maxDistance++;
                            break;
                        case 3:
                            currentDistance = 0;
                            directionSwitch++;
                            break;
                        case 4:
                            currentDistance = 0;
                            directionSwitch = 1;
                            maxDistance++;
                            break;
                    }
                }
                else
                {
                    currentNumber++;
                    currentDistance++;
                    switch (directionSwitch)
                    {
                        case 1:
                            x++;
                            break;
                        case 2:
                            y++;
                            break;
                        case 3:
                            x--;
                            break;
                        case 4:
                            y--;
                            break;
                    }
                }
            }
            return new Tuple<int, int>(x, y);
        }
    }
}
