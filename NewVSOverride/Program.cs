using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVSOverride
{
    public class Base
    {
        public virtual void SomeMethod()
        {
            Console.WriteLine("Base was called!");
        }

        public virtual void SomeOtherMethod()
        {
            Console.WriteLine("Base was called!");
        }
    }

    public class Derived : Base
    {
        //Using "new" modifier
        public new void SomeOtherMethod()
        {
            Console.WriteLine("Dervided was called!");
        }

        //Using "override" modifier
        public override void SomeMethod()
        {
            Console.WriteLine("Dervided was called!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //When using override:
            //Both instances will be calling the derived method.
            Base b = new Derived();
            Derived d = new Derived();
            
            //"Base was called!"
            b.SomeOtherMethod();

            //"Derived was called!";
            d.SomeOtherMethod();

            //"Derived was called!";
            b.SomeMethod();

            //"Derived was called!";
            d.SomeMethod();
        }
    }
}
