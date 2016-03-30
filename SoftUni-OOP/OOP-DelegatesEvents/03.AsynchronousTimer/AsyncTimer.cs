using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.AsynchronousTimer
{
    class AsyncTimer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action">a method to be called on every t milliseconds</param>
        /// <param name="ticks">the number of times the method should be called</param>
        /// <param name="interval">time interval between each tick in milliseconds</param>
        public AsyncTimer(Action action, int ticks, int interval)
        {
            Action = action;
            Ticks = ticks;
            Interval = interval;
        }

        public Action Action { get; private set; }
        public int Ticks { get; private set; }
        public int Interval { get; private set; }

        public void Execute()
        {
            Thread paralelThread = new Thread(this.Run);
            paralelThread.Start();
        }

        private void Run()
        {
            for (int i = 0; i < Ticks; i++)
            {
                Thread.Sleep(Interval);
                if (Action != null)
                {
                    Action();
                }
            }
        }
    }
}
