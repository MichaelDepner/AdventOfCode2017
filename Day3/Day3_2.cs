using System;
using System.Collections.Generic;
using System.Text;
using Utils;

namespace Day3
{
    public class Day3_2 : ISolver
    {
        public string PuzzleName => "Day 3 Part 2";

        public string Solve(string input)
        {
            int goal = Convert.ToInt32(input);
            var value = FindFirstValueHigherThanGoal(goal);
            return value.ToString();
        }

        private int FindFirstValueHigherThanGoal(int goal)
        {
            var map = new Dictionary<(int, int), int>
            {
                { (0, 0), 1 }
            };
            int x = 0;
            int y = 0;
            int directionSwitch = 1;
            int currentDistance = 0;
            int maxDistance = 1;

            while (map[(x,y)] < goal)
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
                    map.Add((x, y), GetValueForCoord(map, (x, y)));
                }
            }
            return map[(x,y)];
        }

        private int GetValueForCoord(Dictionary<(int,int), int> map, (int,int) coords)
        {
            int x = coords.Item1;
            int y = coords.Item2;
            int sum = 0;
            sum = map.ContainsKey((x - 1, y - 1)) ? sum + map[(x - 1, y - 1)] : sum;
            sum = map.ContainsKey((x - 1, y)) ? sum + map[(x - 1, y)] : sum;
            sum = map.ContainsKey((x - 1, y + 1)) ? sum + map[(x - 1, y + 1)] : sum;
            sum = map.ContainsKey((x, y - 1)) ? sum + map[(x, y - 1)] : sum;
            sum = map.ContainsKey((x, y + 1)) ? sum + map[(x, y + 1)] : sum;
            sum = map.ContainsKey((x + 1, y - 1)) ? sum + map[(x + 1, y - 1)] : sum;
            sum = map.ContainsKey((x + 1, y)) ? sum + map[(x + 1, y)] : sum;
            sum = map.ContainsKey((x + 1, y + 1)) ? sum + map[(x + 1, y + 1)] : sum;
            return sum;
        }

    }
}
