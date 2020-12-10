using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class LeafLine : IComponentShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a line...");
        }

        public void Zoom()
        {
            Console.WriteLine("Line zooming...");
        }
    }
}
