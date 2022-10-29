using System;
using System.Collections.Generic;
using System.Linq;

namespace GooglingExercisesPt2
{
    class Program
    {
        public static void Main()
        {
            List<Int32> list = new List<Int32>(Enumerable.Range(0, 10).Select(x => x = Random.Shared.Next(1, 10)));
            int numToRemove = Random.Shared.Next(1, 10);
            Source.RemoveNumbers(list, numToRemove);

            bool numExists = list.Where(x => x == numToRemove).Count() > 1;

            Console.WriteLine(numExists ? "Correct!" : "Incorrect - " + numToRemove + " still exists in the list.");
        }
    }
}