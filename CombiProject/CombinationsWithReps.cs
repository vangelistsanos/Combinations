using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombiProject
{
    class CombinationsWithReps : Combinations
    {

        public CombinationsWithReps(List<object> lo, int combinationsOf) : base(lo, combinationsOf)
        {
            reset();
        }


        public override void reset()
        {
            indexes.Clear();
            for (int i = 0; i < combinationsOf; i++)
            {
                indexes.Add(0);
            }
        }


        public override double findTotalCombinations()
        {
            return (findCombinationsOf(combinationsOf));
        }


        private double findCombinationsOf(int aValue)
        {
            long totalNumbersInList = combiList.Count();
            if (totalNumbersInList < aValue) return 0;
            // Combinations math type
            //
            //   C = n^k
            //
            double calculatedCombinations = Math.Pow(totalNumbersInList, combinationsOf);
            return calculatedCombinations;
        }





        private int findMostRightIndexThatCanBeMovedForward()
        {
            int i;
            bool canGoForwardInTheMainList;
            for (i = combinationsOf - 1; i >= 0; i--)
            {
                canGoForwardInTheMainList = false;
                if (indexes.ElementAt(i) < combiList.Count() - 1) canGoForwardInTheMainList = true;

                if (canGoForwardInTheMainList)
                {

                    return i;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (indexes.ElementAt(j) < indexes.ElementAt(i))
                        {
                            indexes[i] = 0;
                            return j;
                        }
                    }
                }
            }
            return -1; //nothing can be moved
        }



        public override bool moveToNextCombination()
        {
            int pos = findMostRightIndexThatCanBeMovedForward();
            if (pos != -1)
            {
                int n = indexes.ElementAt(pos) + 1;
                indexes[pos] = n;
               
                return true;
            }
            return false;
        }




        public override List<object> getCurrentCombination()
        {
            try
            {
                List<object> temp = new List<object>();
                for (int i = 0; i < combinationsOf; i++)
                {
                    temp.Add(combiList.ElementAt(indexes.ElementAt(i)));
                }
                return temp;
            }
            catch (Exception e)
            {
                return null;
            }
        }




    
    }
}
