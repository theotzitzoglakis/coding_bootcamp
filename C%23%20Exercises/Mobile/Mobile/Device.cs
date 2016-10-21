using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Device
    {
        public string model { get; private set; }
        public string manufactorer { get; private set; }
        public decimal BasePrice { get; private set; }
        public Battery battery { get; private set; }
        public Screen screen { get; private set; }
        public Usage usage { get; private set; }

        public Device(string model, string manufactorer, decimal BasePrice, Battery battery, Screen screen)
        {
            this.model = model;
            this.manufactorer = manufactorer;
            this.BasePrice = BasePrice;
            this.battery = battery;
            this.screen = screen;
            this.usage = new Usage();
        }

        public static Device Samsung()
        {
            Battery s3batt = new Battery("MGH-1500", 2100);
            Screen s3screen = new Screen("240x360", 200);
            return new Device("S3", "Samsung", 200, s3batt, s3screen);
        }

        public static Device IPhone()
        {
            Battery ibatt = new Battery("IPH-0214", 3000);
            Screen iscreen = new Screen("600x900", 400);
            return new Device("IPhone 6S", "Apple", 950, ibatt, iscreen);
        }

        public static Device LG()
        {
            Battery LGbatt = new Battery("LGB-1245", 2200);
            Screen LGScreen = new Screen("400x600", 300);
            return new Device("G3", "LG", 400, LGbatt, LGScreen);
        }

        public override string ToString()
        {
            return $"Manufactorer: {manufactorer}, Model: {model}, Base Price: {BasePrice}, Battery: {battery.ToString()}, Screen: {screen.ToString()}";
        }
    }
}

