using System;

namespace C_Sharp_Study {
    public class Program {
        private static void Main() {
            Car cityCar = new Car("Casper");
            Car campingCar = new Car();
            Car sportCars = new Car(2);
            Car electricCar = new Car("Ioniq 5");
            
            cityCar.Run();
            
            campingCar.CarName = "Perfect 1200 Platinum";
            campingCar.Run();

            sportCars[0] = "Sports Car 1";
            sportCars[1] = "Sports Car 2";
            
            Console.WriteLine(sportCars[0]);
            Console.WriteLine(sportCars[1]);

            foreach (var name in sportCars) {
                Console.WriteLine(name);
            }

            electricCar.Click += new Car.EventHandler(electricCar.Run);
            electricCar.Click += new Car.EventHandler(electricCar.Run);
            
            electricCar.OnClick();
        }
    }
}
