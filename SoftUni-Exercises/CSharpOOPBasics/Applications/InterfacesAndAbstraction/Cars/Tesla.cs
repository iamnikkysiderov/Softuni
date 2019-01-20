using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : IElectricCar
    {
        public int Battery { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Start { get; set; }

        public string Stop { get; set; }

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
            this.Start = "Start engine";
            this.Stop = "Stop engine";
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
