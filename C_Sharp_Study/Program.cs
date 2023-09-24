using System;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_Study {
    static class C_Sharp_Study {
        public static void Main() {
            int[] nums = { 1, 2, 3 };

            int max = nums.Aggregate((f, s) => {
                Console.WriteLine(f > s ? f : s);
                Console.WriteLine("f: " + f);
                Console.WriteLine("s: " + s);
                return f + s;
            });
            Console.WriteLine(max);
        }
    }   
}