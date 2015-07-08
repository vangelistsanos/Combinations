using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombiProject
{
    abstract public class Combinations
    {
        public List<int> indexes;
        public List<object> combiList;
        public int combinationsOf;

        public Combinations(List<object> lo, int combinationsOf)
        {
            indexes = new List<int>();
            combiList = lo;

            if (lo.Count() < combinationsOf)
            {
                this.combinationsOf = lo.Count();
            }
            else
            {
                this.combinationsOf = combinationsOf;
            }
        }

        public abstract void reset();   

        public abstract double findTotalCombinations();   

        public abstract bool moveToNextCombination();   

        public abstract List<object> getCurrentCombination(); 

        
    }
}
