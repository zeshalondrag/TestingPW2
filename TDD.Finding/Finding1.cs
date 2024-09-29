using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TDD.Finding
{
    public class Finding1
    {
        public static string FindShortestWord(string proposal)
        {
            string[] slovo = proposal.Split(' ');
            string shortslovo = slovo[0];

            foreach (string slovo1 in slovo)
            {
                if (slovo1.Length < shortslovo.Length)
                {
                    shortslovo = slovo1;
                }
            }
            return shortslovo;
        }

        public static int CountWords(string proposal)
        {
            List<int> slova = new List<int>();
            int count = 0;
            for (int i = 0; i <= proposal.Length; i++)
            {
                try
                {
                    if (proposal[i] == ' ')
                    {
                        slova.Add(count);
                        count = 0;
                    }
                    else count++;
                }
                catch (Exception)
                {
                    slova.Add(count);
                    count = 0;
                }
            }
            return slova.Count;
        }

        public static int CountCharacters(string proposal)
        {
            return proposal.Length;
        }

        public static int FindNinthCharacter(string proposal)
        {
            return proposal[8];
        }

        public static int CountDigits(string proposal)
        {
            return proposal.Count(char.IsDigit);
        }

        public static int FindMaxConsecutiveDigits(string proposal)
        {
            int maxChifer = 0;
            int currentChifer = 0;

            foreach (char chifers in proposal)
            {
                if (char.IsDigit(chifers))
                {
                    currentChifer++;
                    maxChifer = Math.Max(maxChifer, currentChifer);
                }
                else currentChifer = 0;
            }
            return maxChifer;
        }

        public static int CountAmCombinations(string proposal)
        {
            return Regex.Matches(proposal, "ам").Count;
        }
    }
}