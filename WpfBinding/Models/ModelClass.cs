using System;
using System.Collections.Generic;
using System.Text;

namespace WpfBinding.Models
{
    public class ModelClass
    {
        public ModelClass()
        {
            Value1 = 123.45;
            Value2 = 123.45;
            Value3 = 123.45;
            Value4 = 123.45;
            Value5 = 123.45;
        }

        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Value3 { get; set; }
        public double Value4 { get; set; }
        public double Value5 { get; set; }
    }
}
