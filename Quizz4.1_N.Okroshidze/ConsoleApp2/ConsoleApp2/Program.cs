using System;
using System.Linq;

namespace CSharpExercises.Exercises.LINQ
{
    class MostFrequentCharacterTask
    {
        public static void Main()
        {
            string str = "49fjs492jfJs94KfoedK0iejksKdsj3";

            var mostFrequentCharacter = str.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;

            Console.Write(mostFrequentCharacter);
        }
    }
}