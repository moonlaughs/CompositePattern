using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class LeafTriangle : IComponentShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a triangle...");
        }

        public void Zoom()
        {
            Console.WriteLine("triangle zooming...");
        }
    }
}
