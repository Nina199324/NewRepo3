using System;
using System.Linq;

namespace LinQ5
{
    class MostFrequentCharacterTask
    {
        public static void Main()
        {
            string str = "I work for HeidelbergCement Georgia";

            var mostFrequentCharacter = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;
            Console.WriteLine("Most Frequent Character is:");
            Console.Write(mostFrequentCharacter);
        }
    }
}