using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Assert = NUnit.Framework.Assert;

namespace TestSorting.Sorting
{
    [TestClass]
    public class InsertionSort
    {
        UnitData sortingTest = new();
        int iterations = 1;

        [TestMethod]
        public void SortMethod()
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

            //TODO: Make sorting algorithm
            do
            {
                int selectedItem = sortingTest.data[iterations];

                if (selectedItem < sortingTest.data[iterations - 1])
                {
                    for (int i = iterations - 1; i >= 0; i--)
                    {
                        sortingTest.data[i + 1] = sortingTest.data[i];
                        if (i == 0)
                        {
                            sortingTest.data[i] = selectedItem;
                        }
                        else if (sortingTest.data[i - 1] < selectedItem)
                        {
                            sortingTest.data[i] = selectedItem;
                            break;
                        }
                    }
                }

                iterations++;

            }while (iterations < sortingTest.data.Length);

            Console.WriteLine(sortingTest.data.ToString());
        }
    }
}