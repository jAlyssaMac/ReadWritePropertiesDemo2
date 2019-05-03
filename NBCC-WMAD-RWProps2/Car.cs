using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    public class Car
    {
        //That's why you need to instantiate or whatever string variables before adding to it while int you don't have to
        //Nor did I, but I would get run time errors for it all the time and now it finally makes sense why
        //I'll try it later!
        private int? speed;
        private Nullable<decimal> price;
        private int numberOfDoors;
        private string carType;

        public int? Year { get; set; }

        public int? Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Nullable<decimal> Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int NumberOfDoors
        {
            get
            {
                return numberOfDoors;
            }
            set
            {
                if (value < 10)
                {
                    numberOfDoors = value;
                }
            }
        }

        public string CarType
        {
            get
            {
                return carType;
            }
            set
            {
                carType = value;
            }
        }
    }
}
