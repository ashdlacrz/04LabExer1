using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04LabExercise1
{
    class MyThreadClass
    {

        public static void Thread1()
        {
            for(int a = 0; a < 6; a++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + a);
                Thread.Sleep(1500); //Thread sleep or pause for 1.5 seconds.
            }

        }

    }
}
