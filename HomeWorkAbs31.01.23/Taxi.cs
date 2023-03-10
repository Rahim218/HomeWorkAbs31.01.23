using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkAbs31._01._23
{
    internal class Taxi : Transport,IArrivalTime,IPay
    {
        const double FareFor1km = 1.25;
        public Taxi(int distance)
        {
            Distance = distance;
            _fare = Distance * FareFor1km;
            _currentcountseat = 8;
            MinuteFor1km = 1;
        }
       
        
        public override double Fare 
        {
            set
            {
                if (value >= Distance * FareFor1km)
                {
                    _fare = value;
                }
            }
            get
            {
                return _fare;
            }
        }
        public override int CurrentCountSeat 
        {
            set
            {
                if ( CountPerson(value))
                {
                    _currentcountseat = value;
                }
            }
            get
            {
                return _currentcountseat;
            }
        }

        public override bool CountPerson(int count)
        {
            if (count <= _currentcountseat)
            {
                return true;
            }
            return false;
        }
        public void Pay(double money)
        {
            if (Fare <= money)
            {
                Console.WriteLine($" Balansinizda {money - Fare} qepik vesati qaldi");
            }
            else
            {
                Console.WriteLine("Blansinizda kifayet qeder mebleg yoxdur");
            }
        }


        public void ArrivalTime()
        {
            Console.WriteLine($"Qeyd etdiyiniz yere catma vaxti {MinuteFor1km*Distance} deqiqedir");
        }
    }
}
