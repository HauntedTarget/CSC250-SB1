using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestSorting.Sorting
{
    public class InsertionSort
    {
        int iterations = 1;

        public int[] SortMethod(int[] unsortedArray)
        {
            //First element of array is counted as a part of the sorted set.
            /*
             * do{
             * 
             * selectedItemNumber = item[iteration]
             * 
             * [Starting from second item going down] if (lower item is higher value than selected)
             * {
             *      for ( int i = iteration - 1; i > 0; i--) [i = middle item, i + 1 = selected, i - 1 = next item]
             *      {
             *          Move swap item[i] & item[i+1];
             *          if (item[i-1] < selectedItemNumber)
             *          {
             *              item[i] = selectecItemNumber;
             *              break;
             *          }
             *      }
             * }
             * 
             * iterations++;
             * 
             * }while (while iterations < item.length)
             */

            do
            {
                if (unsortedArray.Length < 2) break;

                int selectedItem = unsortedArray[iterations];

                if (selectedItem < unsortedArray[iterations - 1])
                {
                    for (int i = iterations - 1; i >= 0; i--)
                    {
                        unsortedArray[i + 1] = unsortedArray[i];
                        if (i == 0)
                        {
                            unsortedArray[i] = selectedItem;
                        }
                        else if (unsortedArray[i - 1] < selectedItem)
                        {
                            unsortedArray[i] = selectedItem;
                            break;
                        }
                    }
                }

                iterations++;

            }while (iterations < unsortedArray.Length);

            Console.WriteLine(unsortedArray.ToString());

            return unsortedArray;
        }
    }
}