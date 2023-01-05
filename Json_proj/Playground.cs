using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_proj
{
    internal class Playground
    {
        public void Test()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>() { 1, 2, 4, 3 };

            var result = list1.Except(list2).ToList<int>();
            foreach (int r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
