using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverride
{
    public class Canvas
    {
        public void DrawShaped(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
