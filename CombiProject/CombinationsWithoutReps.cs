using System;
using System.Collections.Generic;
using System.Linq;


namespace CombiProject
{
    public class CombinationsWithoutReps : Combinations 
    {
        public CombinationsWithoutReps(List<object> lo, int combinationsOf) : base (lo,combinationsOf)
        {           
            reset();
        }

        
        public override void reset()
        {
            indexes.Clear();
            for (int i = 0; i < combinationsOf; i++)
            {
                indexes.Add(i);
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
            //         (n!)
            //   C = ----------
            //       (k!)(n-k)!
            //
            double calculatedCombinations = CommonUtil.factorialX(totalNumbersInList) / (CommonUtil.factorialX(aValue) * CommonUtil.factorialX(totalNumbersInList - aValue));
            return calculatedCombinations;
        }


        private void putAllRemaingIndexesInFrontOfThis(int indexPos)
        {
            int incr = 1;
            for (int i = indexPos + 1; i < combinationsOf; i++)
            {
                int n = indexes.ElementAt(indexPos) + incr;
                indexes[i] = n;
                incr++;
            }
        }


        private int findMostRightIndexThatCanBeMovedForward()
        {
            int i;
            bool canGoForwardInTheMainList;
            bool thereIsAnotherIndexInFront;
            for (i = combinationsOf - 1; i >= 0; i--)
            {
                canGoForwardInTheMainList = false;
                thereIsAnotherIndexInFront = false;
                if (indexes.ElementAt(i) < combiList.Count() - 1) canGoForwardInTheMainList = true;

                if (i < combinationsOf - 1)
                {
                    if (indexes.ElementAt(i + 1) == indexes.ElementAt(i) + 1) thereIsAnotherIndexInFront = true;
                }

                if ((canGoForwardInTheMainList) && (!thereIsAnotherIndexInFront)) return i;
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
                putAllRemaingIndexesInFrontOfThis(pos);
                return true;
            }
            return false;
        }


        

        public override List<object> getCurrentCombination()
        {
            try {
                List<object> temp = new List<object>();
                for (int i = 0; i < combinationsOf; i++)
                {
                    temp.Add(combiList.ElementAt(indexes.ElementAt(i)));
                }
                return temp;
            } catch (Exception e)
            {
                return null;
            }
        }




    }
}
