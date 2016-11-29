using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class GroundPackage
    {
        public const int min_Zip = 00000;//Minimum zip value for validation
        public const int max_Zip = 99999;//Maximum zip value for validation


        private int _originzip;//origin zip in Groundpackage
        private int _destinzip;//Destination zip in Groundpackage
        private double _length;//length in Groundpackage
        private double _width;//width in Groundpackage
        private double _height;//height in in Groundpackage
        private double _weight;// weight in Groundpackage
        double cost;// variable to hold cost 





        
        public GroundPackage(int ozip, int dzip, double l, double w, double h, double we)
        {
            //// Use properties to set in case invalid data sent
            OriginZip = ozip;
            DestinZip = dzip;
            Length = l;
            Width = w;
            Height = h;
            Weight = we;
           
            
        }

        public int OriginZip
        {
            get
            {
                // Precondition:  None
                // Postcondition: The originzip has been returned
                return OriginZip;
            }
            set
            {
                // Precondition:  00000<= value <= 99999
                // Postcondition: The originzip has been set to the specified value
                if ((value >= min_Zip) && (value <= max_Zip))
                    _originzip = value;
            }
        }

        public int DestinZip
        {
            get
            {
                // Precondition:  None
                // Postcondition: The destinationzip has been returned
                return DestinZip;
            }
            set
            {
                // Precondition:  00000<= value <= 99999
                // Postcondition: The destinationzip has been set to the specified value
                if ((value >= min_Zip) && (value <= max_Zip))
                    _destinzip = value;
            }
        }

        public double Length
        {
            get
            {
                // Precondition:  None
                // Postcondition: The length has been returned
                return Length;
            }
            set
            {
                // Precondition:  value >= 0
                // Postcondition: The length has been set to the specified value
                if ((value > 0))
                    _length = value;
            }
        }

        public double Width
        {
            get
            {
                // Precondition:  None
                // Postcondition: The width has been returned
                return Width;
            }
            set
            {
                // Precondition:  value >= 0
                // Postcondition: The width has been set to the specified value
                if ((value > 0))
                    _width = value;
            }
        }

        public double Height
        {
            get
            {
                // Precondition:  None
                // Postcondition: The height has been returned
                return Height;
            }
            set
            {
                // Precondition:  value >= 0
                // Postcondition: The height has been set to the specified value
            if((value>0))
            _height=value;
        }
    }
        public double Weight
        {
            get
            {
                // Precondition:  None
                // Postcondition: The weight has been returned
                return Weight;
            }
            set
            {
                // Precondition:  value >= 0
                // Postcondition: The weight has been set to the specified value
                if ((value > 0))
                    _weight = value;
            }
        }
        public int ZoneDistance
        {
            get
            {
                // Precondition:  None
                // Postcondition: The ZoneDistance has been returned
                return ZoneDistance;
               
                }
        }

        public double CalcCost()//method used to calculate cost 
        {
            // Precondition:  None
            // Postcondition: cost value returned 
            return cost=.20*(Length + Width + Height) + .5*(ZoneDistance + 1) * (Weight);
        }

        public override string ToString()
        {
            // Precondition:  None
            // Postcondition: A string is returned representing the GroundPackage in form
            //                all values displayed in separate lines
            return  "Origin Zip:" + OriginZip.ToString("D4") + "/n" + "Destination Zip:" + DestinZip.ToString("D4")
                + "/n" + "Length:" + Length.ToString("") + "/n" + "Width:" + Width.ToString("")
                + "/n" +"Height:" + Height.ToString("") + "/n" + "Weight:" + Weight.ToString("");
        }









    }
}
