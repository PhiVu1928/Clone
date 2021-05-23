using System;
using System.Collections.Generic;
using System.Text;

namespace CloneApp.Model
{
    public class Cart
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductSize { get; set; }

        public string ProductImage { get; set; }

        public float ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}
