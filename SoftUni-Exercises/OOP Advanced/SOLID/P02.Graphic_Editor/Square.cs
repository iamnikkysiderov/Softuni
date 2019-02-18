using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public class Square : IShape
    {
        public object Get { get; private set; }

        public void Draw(IShape shape) { }
    }
}
