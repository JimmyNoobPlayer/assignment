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


        public const double MaxLegalSpeed = 60;
        public const double MinLegalSpeed = -0.01;
        public const string DefaultMake = "Ford";
        public const string DefaultModel = "Pinto";
        public const int DefaultYear = 1990;

        private double currentSpeed;
        public double CurrentSpeed {
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
            this.year = year;
            this.make = make;
            this.model = model;
        }

        public Car()
            :this(DefaultYear,DefaultMake,DefaultModel)
        {}


        //possible feelings caused by the speed
        private const string reverse = "Uh oh, the car is going in reverse? This shouldn't happen!";
        private const string stopped = "Car is parked.";
        private const string slow = "That guy behind you is getting angry, better speed up.";
        private const string moderate = "If you move your arms really fast, it feels like you're running at an incredible speed!";
        private const string prettyFast = "I'm getting nervous now, this is a little faster than I like.";
        private const string tooFast = "Slow down!";

        private const string extraTooSlow = " This is illegally slow.";
        private const string extraTooFast = " This is illegally fast.";

        //set the speed to anything, no checking or modifying the set speed. Also set the feeling based on the speed. THis is the only way to set the Feeling.
        public void setSpeed(double newSpeed) {

            CurrentSpeed = newSpeed;
            if (CurrentSpeed < 0.0) Feeling = reverse;
            else if (CurrentSpeed == 0.0) Feeling = stopped;
            else if (CurrentSpeed < 10.0) Feeling = slow;
            else if (CurrentSpeed < 50.0) Feeling = moderate;
            else Feeling = tooFast;

            if (CurrentSpeed < MinLegalSpeed) Feeling += extraTooSlow;
            if (CurrentSpeed > MaxLegalSpeed) Feeling += extraTooFast;



        }

        //changes the amount of speed,
        //stops at zero, no negative values.
        public void changeSpeed(double change) {
            double newSpeed = CurrentSpeed + change;
            if (newSpeed < 0.0) newSpeed = 0.0;
            setSpeed(newSpeed);
        }

        public void smallSpeedUp() { changeSpeed(1.0); }
        public void bigSpeedUp() { changeSpeed(12.0); }
        public void smallSlowDown() { changeSpeed(-1.0); }
        public void bigSlowDown() { changeSpeed(-12.0); }




    }
}
