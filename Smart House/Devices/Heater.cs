using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Heater : Device, IHeatable, ISwitchable
    {
        public Level Heat { get; set; }
        public Heater(bool state, Level heat)
            : base(state)
        {
            Heat = heat;
        }

        public void SetOn()
        {
            State = true;
        }

        public void SetOff()
        {
            State = false;
        }

        public void SetHeatLow()
        {
            Heat = Level.Low;
        }

        public void SetHeatMed()
        {
            Heat = Level.Medium;
        }

        public void SetHeatHigh()
        {
            Heat = Level.High;
        }

        public override string ToString()
        {
            string state;
            string mode;

            if (Heat == Level.Low)
            {
                mode = "Low";
            }
            else if (Heat == Level.Medium)
            {
                mode = "Medium";
            }
            else
            {
                mode = "High";
            }

            if (State)
            {
                state = "on";
            }
            else
            {
                state = "off";
            }

            return ", Power is " + state + ", Heat level is " + mode;
        }
    }
}
