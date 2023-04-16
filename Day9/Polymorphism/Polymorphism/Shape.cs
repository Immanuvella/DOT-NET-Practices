using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1   //Ploymorphism Sample Question
{
    public class Shape
    {
        public virtual void Drawshape()
        {
            Console.WriteLine("Drawing shape");
        }
    }
    public class Circle : Shape
    {
        public override void Drawshape()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}