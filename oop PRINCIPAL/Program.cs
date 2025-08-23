using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_PRINCIPAL
{
    class Polygon
    {

        // method to render a shape 
        public virtual void render()
        {
            Console.WriteLine("Rendering Polygon...");

        }
        class Square : Polygon
        {
            // overriding render() method  
            public override void render()
            {
                base.render();
                Console.WriteLine("Rendering Square...");

            }
        }
        class myProgram
        {
            public static void Main()
            {
                // obj1 is the object of Polygon class 
                Polygon obj1 = new Polygon();

                // calls render() method of Polygon Superclass  

                // here, obj1 is the object of derived class Square  
                obj1 = new Square();

                // calls render() method of derived class Square 
                obj1.render();
            }
        }
    }
}

