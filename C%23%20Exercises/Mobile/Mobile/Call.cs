using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Call
    {
        public DateTime CallStart { get; private set; }
        public DateTime CallEnd { get; private set; }
        public CallDirection direction;

        public enum CallDirection
        {
            Incoming,
            Outgoing
        }

        public double Duration
        {
            get
            {
                {
                    TimeSpan span = CallEnd - CallStart;
                    return span.Seconds;
                }
            }
        }
        

        public Call(CallDirection direction)
        {
            this.direction = direction;
            CallStart = DateTime.Now;
        }

        public void End()
        {
            CallEnd = DateTime.Now;
        }
    }
}
