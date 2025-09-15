using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class TaskAsyncClass
    {
        public static async Task<string> SecondTask()
        {
      
            for (int i = 1; i <= 10; i++) 
            {
                await Task.Delay(1000);
                Console.WriteLine($"{i} second");
            }

            return "END";
        }
    }
}
