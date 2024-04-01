using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSorting
{
    public class UnitData
    {
        public int[] data = [5, 82, 8, 12, 1, 3];
        public int[] sortedData = [1, 3, 5, 8, 12, 82];

        public UnitData() 
        {

        }

        public bool CheckSort()
        {
            return data.SequenceEqual(sortedData);
        }
    }
}
