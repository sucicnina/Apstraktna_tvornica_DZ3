﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstraktna_tvornica_DZ3
{
    public class WaterGoblin : IGoblin
    {
        public void DoDamage()
        {
            Console.WriteLine("Do Water Damage");
        }
    }
}