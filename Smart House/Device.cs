﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public abstract class Device
    {
        public bool State { get; set; }

        public Device(bool state)
        {
            State = state;
        }
    }
}
