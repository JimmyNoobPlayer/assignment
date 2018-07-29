using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1Car {
    class Program {

        static void displayControls()
        {
            Console.WriteLine("(A)ccelerate, (B)rake, (F)loor it, (S)lam the brakes, attempt to (P)ark.");
        }

        static void Main(string[] args) {

            //inside a loop
            
            Char.TryParse(Console.ReadLine())






//            The car driving game: car has a speed, console displayed stuff: (A)ccelerate, (B)rake, (F)loor it, (S)lam the brakes, (P)ark
//park only when stopped, speed can't go negative

//Car constructors should update the static value of the number of cars made(doesn't track when cars are destroyed)
//also has MAX_SPEED and MIN_SPEED

////instance ctor (ctor tab- tab)
//        public Car(string make, string model, int year, decimal price) {
//            //initialize all the stuff
//            this.make = make; make these readonly because they are only created once at object construction
//this.model = model;
//            this.year = year;
//            this.price = price;

//            Car.numberOfCarsMade++;
//        }

//        Static constructor is called before any other objects are made
//static Car() {
//            numberOfCars = 0;
//        }

//        parameter ctor, empty default ctor, deep copy ctor, and the static ctor(that isn't called by any code)
//DisplayInfo shows all the info of the car, as well as the global
        

//        Properties

//        prop -tab-tab
//          propfull -tab-tab

//public string Model {
//            get { return model; }
//            private set { model = value; }
//        }

//        private int size;
//        public int Size {
//            get { return size; }
//            set {
//                if (value < 0) { Size = 0; } else { Size = value; }
//            }
//        }


    }
    }
}
