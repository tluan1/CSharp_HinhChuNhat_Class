﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class Hinhchunhat
    {
        public double chieucao;
        public double chieurong;
        public double tinhdientich()
        {
            return chieucao * chieurong;
        }
        public double tinhchuvi()
        {
            return (chieucao + chieurong) * 2;
        }
    }
}
