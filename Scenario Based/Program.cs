using Scenario_Based.Classes.Inheritance_based;
using Scenario_Based.Classes.Tasks;
using System;

namespace Test
{
    public class program
    {
        static void Main(string[] args)
        {
            /*   //// Inheritance based 
            Parent parent = new Parent();
            Console.WriteLine("Parent parent = new Parent();parent.NonVirtualParent() - " + parent.NonVirtualParent());
            Console.WriteLine("Parent parent = new Parent();parent.ParentMethod() - " + parent.ParentMethod());
            Console.WriteLine("Parent parent = new Parent();parent.HidedMethod() - " + parent.HidedMethod());
            
            Child child = new Child();
            Console.WriteLine("Child child = new Child();; NonVirtualParent - " + child.NonVirtualParent());
            Console.WriteLine("Child child = new Child();; NonOverride - " + child.NonOverride());
            Console.WriteLine("Child child = new Child();; ParentMethod - " + child.ParentMethod());
            Console.WriteLine("Child child = new Child();; HidedMethod - " + child.HidedMethod()); 

            Parent chld = new Child();
            Console.WriteLine("Parent chld = new Child();;NonVirtualParent - " + chld.NonVirtualParent());
         //throws error   //Console.WriteLine("Parent parent = new Parent(); NonOverride - " + chld.NonOverride());
            Console.WriteLine("Parent chld = new Child();; ParentMethod - " + chld.ParentMethod());
            Console.WriteLine("Static COns " + StaticCons.StatMethod());

            GrandChild gchd = new GrandChild();
            Console.WriteLine("GrandChild gchd = new GrandChild(); : " + gchd.NonVirtualParent());

            Child chldg = new GrandChild();
            Console.WriteLine("Child chldg = new GrandChild(); " + chldg.NonVirtualParent());
            */

            TasksBased taskBased = new TasksBased();

            Console.WriteLine("Start");
            taskBased.InvokeMethod();
            //taskBased.SecondCase();
            taskBased.ThirdCase();
            taskBased.FourthCase();
            Console.WriteLine("Method Invoked");
        }
        
    }
}
