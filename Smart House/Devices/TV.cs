using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class TV : Device, ISwitchable, IChannelable, IVolumable
    {
        
        public int Channel { get; set; }
        public int Volume { get; set; }
     

        public TV(bool state, int channel,int volume)
            : base(state)
        {
            Channel = channel;
            Volume = volume;
        }
        void ISwitchable.SetOn()
        {
            State = true;
        }

        void ISwitchable.SetOff()
        {
            State = false;
        }

        public void SetChannelUp()
        {
            Channel++;
        }

        public void SetChannelDown()
        {
            Channel--;
        }

        public void SetVolumeUp()
        {
            Volume++;
        }

        public void SetVolumeDown()
        {
            Volume--;
        }

        public override string ToString()
        {
            string state;

            string channel = Channel.ToString();

            string volume = Volume.ToString();

            if (State)
            {
                state = "on";
            }
            else
            {
                state = "off";
            }

            return ", Power is " + state + ", Channel is " + channel + ", Volume is " + volume;
        }
    }
}