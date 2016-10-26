using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Battery
    {
        public string BatteryType { get; private set; }

        public int Capacity
        {
            get
            {
                return _Capacity;
            }

            set
            {
                if (value >= 0 && value < Int32.MaxValue)
                {
                    _Capacity = value;
                }
            }
        }

        private int _Capacity;

        public Battery(string type, int capacity)
        {
            this.BatteryType = type;
            this.Capacity = capacity;
        }

        public override string ToString()
        {
            return $"{BatteryType} / {Capacity} mAh";
        }
    }
}
