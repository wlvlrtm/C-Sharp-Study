using System;
using System.Collections.Generic;
using System.Linq;


namespace C_Sharp_Study {
    public class Program {
        private static void Main() {
            Action<object> print = Console.WriteLine;
            Func<int, int> getnum = (int x) => 123;

            print(getnum(3));
        }
    }
}