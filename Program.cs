using System;
using System.Collections.Generic;
using System.Linq;


namespace C_Sharp_Study {
    public class Program {
        private static void Main() {
            Stack<string> stack = new Stack<string>();

            stack.Push("1");

            List<int> lst = new List<int>();

            foreach (var i in Enumerable.Range(1, 10)) {
                lst.Add(i);
                Console.WriteLine(i);
            }

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic[0] = "test";
            
            Console.WriteLine(dic[0]);

            bool? isNull = null;
            
            Console.WriteLine(isNull);

            int[] nums = { 1, 2, 3 };
            Console.WriteLine(nums.Sum());

            var newNums = nums.Where(n => n > 2);

            foreach (var i in newNums) {
                Console.WriteLine(i);
            }
        }
    }
}