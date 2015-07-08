using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombiProject
{
    public class CommonUtil
    {
        public static double factorialX(long xValue)
        {
            double tempResult = 1;
            for (int i=2; i<= xValue; i++)
            {
                tempResult *= (double)i;
            }
            return tempResult;
        }
    }
}
