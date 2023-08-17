using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Study {
    public class Original {
    }

    public static class OriginalExt {
        public static void NewMethod(this Original original) {
            
        }    
    }
    
    static class Program {
        static string Three(this string val) {
            return val.Substring(0, 3);
        }
        
        private static void Main() {
            List<Person> people = new List<Person>();
            
            people.Add(new Person() { Name = "Kim" });
            people.Add(new Person() { Name = "Han" });

            foreach (var person in people) {
                Console.WriteLine(person.Name);
            }

            var categories = new List<Category>() {
                new Category() { CategoryId = 1, CategoryName = "Book" },
                new Category() { CategoryId = 2, CategoryName = "Desktop" },
                new Category() { CategoryId = 3, CategoryName = "Laptop" }
            };

            foreach (var category in categories) {
                Console.WriteLine($"{category.CategoryId}, {category.CategoryName}");
            }

            var q_categories = 
                from category in categories
                where category.CategoryId == 1
                select category;

            foreach (var qCategory in q_categories) {
                Console.WriteLine(qCategory.CategoryId);
                Console.WriteLine(qCategory.CategoryName);
            }

            Multi<string> title = new Multi<string>();
            title.Data = "data";

            Multi<int> num = new Multi<int>();
            num.Data = 1;
            
            Console.WriteLine(title.Data);
            Console.WriteLine(num.Data);

            Cup<Juice> juiceCup = new Cup<Juice>();
            juiceCup.Type = new Juice();
            Console.WriteLine(juiceCup.Type.ToString());

            Cup<Coffee> coffeeCup = new Cup<Coffee>();
            coffeeCup.Type = new Coffee();
            Console.WriteLine(coffeeCup.Type.ToString());

            var myPair = new Pair<string, bool>("Hello, world!", true);
            var yourPair = new Pair<int, float>(3, 3.14f);
            
            Console.WriteLine(myPair.First);
            Console.WriteLine(myPair.Second);
            Console.WriteLine(yourPair.First);
            Console.WriteLine(yourPair.Second);
            
            Console.WriteLine("Hello, world!".Three());
        }
    }
}
