﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolTestIPCamera_Ver1.Function.Excute
{
    public class ExcuteTestLayer3 : DUT.IPCamera {

        public bool Excute() {
            try {
                return true;
            }
            catch {
                return false;
            }
        }

    }
}
