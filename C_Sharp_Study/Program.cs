namespace C_Sharp_Study {
    static class C_Sharp_Study {
        static (int, int) Tally() {
            var r = (10, 20);
            return r;
        }
        
        public static void Main() {
            var tup = (1, 2, 3);
            Console.WriteLine(tup.Item1);
            
            var uhd = (Width: 3840, Height: 2160);
            Console.WriteLine($"{uhd.Width}, {uhd.Height}");

            var t = Tally();
            Console.WriteLine(t.Item1);
            
            
        }
    }   
}