using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class CompositeDrawing : IComponentShape
    {
        private List<IComponentShape> components;

        public CompositeDrawing()
        {
            components = new List<IComponentShape>();
        }

        public void Draw()
        {
            foreach (IComponentShape item in components)
            {
                item.Draw();
            }
        }

        public void AddComp(IComponentShape c)
        {
            components.Add(c);
        }

        public void RemoveComp(IComponentShape c)
        {
            components.Remove(c);
        }

        public void Zoom()
        {
            Console.WriteLine("Composite zoom...");
            foreach (IComponentShape item in components)
            {
                item.Zoom();
            }
        }
    }
}
