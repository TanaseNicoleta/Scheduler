using System;
using System.Collections.Generic;
using System.Text;

namespace BarChartLibrary
{
    class BarChartValue
    {
        public float value { get; set; }
        public string Label { get; set; }
        public string Color { get; set; }

        public BarChartValue(float value, string label, string color)
        {
            this.value = value;
            Label = label;
            Color = color;
        }


    }
}
