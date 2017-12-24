using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SelectionSort : SortAlgorithm
    {
        public SelectionSort(int[] array)
        {
            Array = array;
        }

        public override void Sort()
        {
            int min;
            int indexJ = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                min = Array[i];

                for (int j = i; j < Array.Length; j++)
                {
                    if (min > Array[j])
                    {
                        min = Array[j];
                        indexJ = j;
                    }
                }

                if (min != Array[i])
                {
                    Swap(Array, i, indexJ);
                }
            }
        }
    }
}
