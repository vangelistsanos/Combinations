# Combinations
Combinations of Objects with and without Repetition.


Simple classes that help you find all combinations of a list of objects. 
Very useful for game cards and puzzle games. Very simple usage. (Check program.cs)

e.g.
//FIND ALL COMBINATIONS OF LOTTO </br>
//(really want to wait that much 13.983.816 combinations ???)</br>
CombinationsWithoutReps cwr = new CombinationsWithoutReps(new List<object> { "1", "2", "3", "4","5","6","7","8","9","10",</br>
 "11", "12", "13", "14","15","16","17","18","19","20",</br>
"21", "22", "23", "24","25","26","27","28","29","30",</br>
"31", "32", "33", "34","35","36","37","38","39","40",</br>
"41", "42", "43", "44","45","46","47","48","49" }</br>
, 6);
</br>
Console.WriteLine("Total Combinations " + cwr.findTotalCombinations());</br>
do</br>
{</br>
   foreach (String s in cwr.getCurrentCombination())</br>
   {</br>
        Console.Write(s + " ");</br>
    }</br>
  Console.WriteLine();</br>
} while (cwr.moveToNextCombination());</br>


