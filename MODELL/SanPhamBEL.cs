﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Chauquoctoan.MODELL
{
    public class SanPhamBEL
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity_in_stock { get; set; }
         

        public string Image { get; set; }
    }
}