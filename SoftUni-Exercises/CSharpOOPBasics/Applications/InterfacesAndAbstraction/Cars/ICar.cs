using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public interface ICar
    { 
        string Model { get; }

        string Color { get; }

        string Start { get; }

        string Stop { get; }
    }
}
