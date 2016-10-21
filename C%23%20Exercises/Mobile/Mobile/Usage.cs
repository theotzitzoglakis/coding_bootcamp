using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Usage
    {
        public int BattPercentage { get; private set; }
        public string OS { get; private set; }
        public List<Call> History = new List<Call>();

        public Usage()
        {
            BattPercentage = 100;
            History = new List<Call>();
        }

        public void NewCall(Call.CallDirection type)
        {
            History.Add(new Call(type));
        }

        public void EndCall()
        {
            History[History.Count - 1].End();
        }

        public override string ToString()
        {
            string result = "";
            result += "Battery" + BattPercentage + "%\n";
            result += "Call History: \n";
            foreach (Call call in History)
            {
                result+= String.Format("Start Time: {0} | Duration: {1} seconds \n", call.CallStart.ToString(), call.Duration);
            }
            return result;
        }
    }
}
