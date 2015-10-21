using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    interface ICoolable
    {
        void SetCoolLow();

        void SetCoolMed();

        void SetCoolHigh();
    }
}