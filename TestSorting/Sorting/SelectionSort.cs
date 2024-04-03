using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestSorting.Sorting
{
    public class SelectionSort
    {
        int iterations = 0, lowestNum = 0;

        public int[] SortMethod(int[] unsortedArray)
        {
            //First element of array is start.
            /*
             * int iterations = 0, lowestNum;
             * 
             * do{
             *  
             *  selectedItemNumber = item[iteration];
             *  lowestNum = item[iteration];
             *
             *  int i = 0;
             *  for ( i = iteration + 1; i < item.length; i++) [iteration = place to swap, i = place to check, lowestNum = lowest number found]
             *  {
             *      if ( item[i] < lowestNum )
             *      {
             *          lowestNum = item[i];
             *      }
             *  }
             *  item[i] = item[iteration];
             *  item[iteration] = lowestNum;
             * 
             * iterations++;
             * 
             * }while (while iterations < item.length)
             */


            do
            {
                if (unsortedArray.Length < 2) break;

                int selectedItem = unsortedArray[iterations];
                int lowestNum = unsortedArray[iterations];
                int lowestI = 0 + iterations;

                for (int i = 0 + iterations; i < unsortedArray.Length; i++)
                {
                    if (unsortedArray[i] < lowestNum)
                    {
                        lowestI = i;
                        lowestNum = unsortedArray[i];
                    }
                }

                unsortedArray[lowestI] = selectedItem;
                unsortedArray[iterations] = lowestNum;

                iterations++;

            } while (iterations < unsortedArray.Length);

            Console.WriteLine(unsortedArray.ToString());

            return unsortedArray;
        }
    }
}