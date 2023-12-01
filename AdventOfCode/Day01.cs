using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day01
    {
        private List<string> _lines = new List<string>();

        public Day01(string input) {
            _lines = input.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
        }

        public int SolveChallenge01() {
            int sum = 0;
            foreach (string line in _lines) {
                sum += LineToNumber(line);
            }
            return sum;
        }

        public int SolveChallenge02() {
            int sum = 0;
            foreach (string line in _lines) {
                StringBuilder sb = new StringBuilder(line);
                sb.Replace("one",   "o1e");
                sb.Replace("two",   "t2o");
                sb.Replace("three", "t3e");
                sb.Replace("four",  "4");
                sb.Replace("five",  "5e");
                sb.Replace("six",   "6");
                sb.Replace("seven", "7n");
                sb.Replace("eight", "e8t");
                sb.Replace("nine",  "n9e");

                string convertedLine = sb.ToString();

                sum += LineToNumber(convertedLine);
            }
            return sum;
        }

        private static int LineToNumber(string line) {
            char[] numbers = line.ToCharArray().Where(char.IsDigit).ToArray();
            if (int.TryParse($"{numbers[0]}{numbers[^1]}", out int result)) {
                return result;
            }
            return 0;
        }
    }
}
