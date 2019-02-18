using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public interface IShape
    {
        object Get { get; }

        void Draw(IShape shape);
    }
}
