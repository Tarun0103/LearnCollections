using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Classes.Inheritance_based
{
    public class Parent
    {
        private int _id = 10;

        public Parent() { Console.WriteLine("Parent Constructor ");  }
        public virtual string ParentMethod()
        {
            return "ParentClass" + _id;
        }
        public string NonVirtualParent()
        {
            return "Non Virtual Parent";
        }
        public string HidedMethod()
        {
            return "Parent HideMethod";
        }
    }
    public class Child : Parent
    {
        public Child() : base()  // Calling the base class constructor and then child class contructor
        {
            Console.WriteLine("Child constructor called.");
        }
        int c_id = 20;
        public override string ParentMethod()
        {
            return "child" + c_id;
        }
        public string NonOverride()
        {
            return "NonOverRide child";
        }
        public new string HidedMethod()
        {
            return "Child HideMethod";
        }
    }

    public class GrandChild : Child
    {
        public string ParentMethod()
        {
            return "parent in grand child";
        }
        public string GrandChildMethod()
        {
            return "Grand Child";
        }
    }
    public class StaticCons
    {
        static StaticCons()
        {
            Console.WriteLine("Static Cons");
        }

        public static string StatMethod()
        {
            return "Stat Method";
        }
    }

}
