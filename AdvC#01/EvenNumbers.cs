using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_01
{
    public class ListProcessor
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }
    }

}
