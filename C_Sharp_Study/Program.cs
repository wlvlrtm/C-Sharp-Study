using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Study {
    static class C_Sharp_Study {
        public static void Main() {
            Thread thread = new Thread(new ThreadStart(ThreadDemo));
            
            //Parallel.For(0, 5000_0000, (i) => { Console.WriteLine(i); });
            
            for (int i = 0; i <= 5000_0000; i++) {
                Console.WriteLine(i);
            }
            
            thread.Start();
        }

        public static void ThreadDemo() {
            Console.Write("Hello, ");
            Thread.Sleep(1000);
            Console.WriteLine("world!");
        }
    }   
}