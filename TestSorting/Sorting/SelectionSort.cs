using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestSorting.Sorting
{
    [TestClass]
    public class SelectionSort
    {
        UnitData sortingTest = new();
        int iterations = 0, lowestNum = 0;

        [TestMethod]
        public void SortMethod()
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
                int selectedItem = sortingTest.data[iterations];
                int lowestNum = sortingTest.data[iterations];
                int lowestI = 0 + iterations;

                for (int i = 0 + iterations; i < sortingTest.data.Length; i++)
                {
                    if (sortingTest.data[i] < lowestNum)
                    {
                        lowestI = i;
                        lowestNum = sortingTest.data[i];
                    }
                }

                sortingTest.data[lowestI] = selectedItem;
                sortingTest.data[iterations] = lowestNum;

                iterations++;

            } while (iterations < sortingTest.data.Length);

            Console.WriteLine(sortingTest.data.ToString());

            Assert.AreEqual(sortingTest.CheckSort(), true);
        }
    }
}