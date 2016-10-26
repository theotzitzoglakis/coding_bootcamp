using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Screen
    {
        public string resolution { get; private set; }
        public int density { get; private set; }

        public Screen(string res, int dens)
        {
            this.resolution = res;
            this.density = dens;
        }

        public override string ToString()
        {
            return $"{resolution} pixels / {density} dpi";
        }
    }
}
