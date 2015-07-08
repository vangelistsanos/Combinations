using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombiProject
{
 
    // samples !!!
    class Program
    {
        static void Main(string[] args)
        {

            //find combinations of 6 out of 7 items
            CombinationsWithoutReps cwr = new CombinationsWithoutReps(new List<object> { "1", "2", "3", "4","5","6","7"}, 6);
            Console.WriteLine("Total Combinations " + cwr.findTotalCombinations());
            do
            {
                foreach (String s in cwr.getCurrentCombination())
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            } while (cwr.moveToNextCombination());


            //find combinations with repetitions of 3 out of 4
            CombinationsWithReps cwor = new CombinationsWithReps(new List<object> { "1", "2", "3" ,"4"}, 3);
            Console.WriteLine("Total Combinations " + cwor.findTotalCombinations());
            do
            {
                foreach (String s in cwor.getCurrentCombination())
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            } while (cwor.moveToNextCombination());

            Console.WriteLine("THE END");
            Console.ReadLine();

        }
    }
}
