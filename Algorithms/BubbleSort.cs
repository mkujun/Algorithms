using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort : SortAlgorithm
    {
        public BubbleSort(int[] array)
        {
            Array = array;
        }

        public bool IsSwaped { get; set; }

        public override void Sort()
        {
            do
            {
                IsSwaped = false;

                for (int i = 0; i < Array.Length - 1; i++)
                {
                    if (Array[i + 1] < Array[i])
                    {
                        Swap(Array, i, i + 1);
                        IsSwaped = true;
                    }
                }

            } while (IsSwaped);
        }
    }
}
