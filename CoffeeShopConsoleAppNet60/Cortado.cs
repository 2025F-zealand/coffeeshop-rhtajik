﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee
    {
        public override int Price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }


        public int mlMilk()
        {
            return 40;
        }
    }
}
