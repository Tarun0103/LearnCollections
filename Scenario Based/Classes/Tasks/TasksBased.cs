using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.Classes.Tasks
{
    public class TasksBased
    {
        public async Task MethodA()
        {
            Task.Delay(3000).Wait();
            Console.WriteLine("Method A");
        }
        public async Task MethodB()
        {
            Console.WriteLine("Method B");
        }

        public async void InvokeMethod()
        {
            await MethodA();
            await MethodB();
        }
        public async void SecondCase()
        {
            await MethodB();
            await MethodA();
        }
        public void ThirdCase()
        {
            MethodA();
            MethodB();
        }
        public void FourthCase()
        {
            MethodB();
            MethodA();
            
        }

    }
}
