using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment1Car {
    class Car {

        private string make;
        public string Make {
            get { return make; }
            private set { make = value; }
        }

        private string model;
        public string Model {
            get { return model; }
            private set { model = value; }
        }

        private int year;
        public int Year {
            get { return year; }
            private set { year = value; }
        }

        static private int numCarsMade;
        static public int NumCarsMade {
            get { return numCarsMade; }
            private set { numCarsMade = value; }
        }


        public const int MaxLegalSpeed=60;
        public const int MinLegalSpeed=0;
        public const string DefaultMake = "Ford";
        public const string DefaultModel = "Pinto";
        public const int DefaultYear = 1990;

        private int currentSpeed;
        public int CurrentSpeed {
            get { return currentSpeed; }
            private set { currentSpeed = value; }
        }
        private string getAFeelingSoComplicated;
        public string Feeling {
            get { return getAFeelingSoComplicated; }
            private set { getAFeelingSoComplicated = value; }
        }


        static Car() {
            NumCarsMade = 0;
        }

        public Car(int year, string make, string model) {
            NumCarsMade++;
        }



        public void setSpeed(int newSpeed) {
            //possible feelings caused by the speed
            private const string stopped = "Car is parked.";
        private const string slow = "That guy behind you is getting angry, better speed up.";
        private const string moderate = "If you move your arms really fast, it feels like you're running at an incredible speed!";
        private const string tooFast = "Slow down!";

            currentSpeed = newSpeed;
            switch(

        }
        public void changeSpeed() {

        }




    }
}
