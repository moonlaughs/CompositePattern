using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composite Pattern");
            Console.WriteLine("==================");
            //IComponent == IShape
            //Composite == Drawing
            //Leaf == Line, Triangle
            CompositeDrawing c1 = new CompositeDrawing(); 
            LeafLine ll = new LeafLine(); 
            LeafTriangle lt = new LeafTriangle();
            c1.AddComp(ll);
            c1.AddComp(lt);
            c1.Draw();
            //c1.Zoom();

            Console.WriteLine("============");
            CompositeDrawing c2 = new CompositeDrawing();
            LeafLine ll2 = new LeafLine();
            LeafTriangle lt2 = new LeafTriangle();
            c2.AddComp(ll2);
            c2.AddComp(ll2); //in real life different lines, not one added multiple times
            c2.AddComp(ll2);
            c2.Draw();
            //c2.Zoom();

            Console.WriteLine("==========");
            CompositeDrawing c3 = new CompositeDrawing();
            c3.AddComp(c1);
            c3.AddComp(c2);
            c3.Draw();
            c3.Zoom();
        }
    }
}
