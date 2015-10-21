using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class AirCon : Device, ISwitchable, ICoolable
    {
        public Level Cool { get; set; }
        public AirCon (bool state, Level cool) : base(state)
        {
            Cool = cool;
        }

        public void SetOn()
        {
            State = true;
        }

        public void SetOff()
        {
            State = false;
        }

        public void SetCoolLow()
        {
            Cool = Level.Low;
        }

        public void SetCoolMed()
        {
            Cool = Level.Medium;
        }

        public void SetCoolHigh()
        {
            Cool = Level.High;
        }

        public override string ToString()
        {
            string state;
            string mode;

            if (Cool == Level.Low)
            {
                mode = "Low";
            }
            else if (Cool == Level.Medium)
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

            return ", Power is " + state + ", Cooling level is " + mode;
        }
    }
}
