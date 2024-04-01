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

        [TestMethod]
        public void SortMethod()
        {
            //TODO: Make sorting algorithm
            Assert.AreEqual(sortingTest.CheckSort(), true);
        }
    }
}