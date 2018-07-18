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

        private int currentSpeed;

        public int CurrentSpeed {
            get { return currentSpeed; }
            private set { currentSpeed = value; }
        }





    }
}
