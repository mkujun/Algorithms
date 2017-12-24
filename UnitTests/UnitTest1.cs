using System;
using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AlgorithmsUnitTest
    {
        [TestMethod]
        public void SelectionSortTestMethod()
        {
            // arrange
            int[] testArray = { 3, 45, 1, 66, 0, 8 };
            int[] expected = { 0, 1, 3, 8, 45, 66 };

            SelectionSort sort = new SelectionSort(testArray);

            // act 
            sort.Sort();

            // assert
            CollectionAssert.AreEqual(expected, sort.Array);
        }

        [TestMethod]
        public void BubbleSortTestMethod()
        {
            // arrange
            int[] testArray = { 3, 45, 1, 66, 0, 8 };
            int[] expected = { 0, 1, 3, 8, 45, 66 };

            BubbleSort sort = new BubbleSort(testArray);

            // act 
            sort.Sort();

            // assert
            CollectionAssert.AreEqual(expected, sort.Array);
        }
    }
}
