﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVSOverride
{
    public class Base
    {
        public virtual void SomeOtherMethod()
        {
            Console.WriteLine("Base was called!");
        }
    }

    public class Derived : Base
    {
        public new void SomeOtherMethod()
        {
            Console.WriteLine("Dervided was called!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
