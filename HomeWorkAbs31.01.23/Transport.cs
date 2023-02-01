using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkAbs31._01._23
{
    internal abstract class Transport 
    {
        public double Distance;
        protected double MinuteFor1km;
        
        protected double _fare;
        protected int _currentcountseat;
        public abstract double Fare { get; set; }

        public abstract int CurrentCountSeat { get; set; }

        public abstract bool CountPerson(int count);
        
    }
}
