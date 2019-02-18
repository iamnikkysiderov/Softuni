using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public class Circle : IShape
    {
        public object Get { get; private set; }

        public void Draw(IShape shape)
        {
            Console.WriteLine(shape.ToString());
        }
    }
}
