using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Signalization : Device, ISwitchable
    {
        public Signalization (bool state)
            : base(state)
        {
           
        }

        void ISwitchable.SetOn()
        {
            State = true;
        }

        void ISwitchable.SetOff()
        {
            State = false;
        }

        public override string ToString()
        {
            string state;

            if (State)
            {
                state = "on";
            }
            else
            {
                state = "off";
            }

            return ", Power is " + state;
        }
    }
}
