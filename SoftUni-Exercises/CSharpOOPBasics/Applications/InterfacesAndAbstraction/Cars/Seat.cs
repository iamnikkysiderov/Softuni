using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Seat : ICar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public string Start { get; set; }

        public string Stop { get; set; }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
            this.Start = "Start engine";
            this.Stop = "Stop engine";
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
