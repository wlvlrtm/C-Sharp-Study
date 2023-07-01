using System;

namespace C_Sharp_Study {
    public class Program {
        static void Main() {
            const float PI = 3.14f;
            sbyte sb = -128;
            int min = int.MinValue;
            int max = int.MaxValue;
            
            Console.WriteLine("{0}, {1}", min, max);
            Console.WriteLine("{0}", PI);
            Console.WriteLine(100_000_000);
            
            Console.WriteLine(2.0 - 1.1);
            Console.WriteLine(Convert.ToDecimal(2.0 - 1.1));

            decimal d = 1.23m;
            float p = 0f;
            
            Console.WriteLine(d);
            Console.WriteLine(p);
            
            decimal.TryParse("1.4", out d);
            float.TryParse("3.14", out p);
            
            Console.WriteLine(d);
            Console.WriteLine(p);

            int? x = 1;
            Console.WriteLine(x);

            string str = @"
                            곰탱이
                            냥탱이
                          ";
            Console.WriteLine(str);
        }
    }
}