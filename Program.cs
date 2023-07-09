using System;

namespace C_Sharp_Study {
    public class Program {
        private static void Main() {
            string color = "Red";

            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);

        }
    }
}