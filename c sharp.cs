using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<int> multi3 = new List<int>{3};
            List<int> multi5 = new List<int>{5};
            List<int> multi5_union_multi3 = new List<int>{15};
            for (int x =6; x< 1000; x+= 3){multi3.Add(x);};
            for (int x =10; x< 1000; x+= 5){multi5.Add(x);};
            for (int x =30; x< 1000; x+= 15){multi5_union_multi3.Add(x);};
            Console.WriteLine(multi3.Sum()+multi5.Sum()-multi5_union_multi3.Sum());
        }
    }
}
