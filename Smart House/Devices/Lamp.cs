using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Lamp : Device, ISwitchable, IBrightable
    {
        public Level Brightness { get; set; }
        public Lamp(bool state, Level brightness): base(state)
        {
            Brightness = brightness;
        }

        void ISwitchable.SetOn()
        {
            State = true;
        }

        void ISwitchable.SetOff()
        {
            State = false;
        }

        void IBrightable.SetBrightLow()
        {
            Brightness = Level.Low;
        }

        void IBrightable.SetBrightMed()
        {
            Brightness = Level.Medium;
        }

        void IBrightable.SetBrightHigh()
        {
            Brightness = Level.High;
        }

        public override string ToString()
        {
            string state;
            string mode = "";

            if (State)
            {
                state = "on";
            }
            else
            {
                state = "off";
            }

            if (Brightness == Level.Low)
            {
                mode = "Low";
            }
            else if (Brightness == Level.Medium)
            {
                mode = "Medium";
            }
            else
            {
                mode = "High";
            }

            return ", Power is " + state + ", Brightness level is " + mode;
        }
    }
}
