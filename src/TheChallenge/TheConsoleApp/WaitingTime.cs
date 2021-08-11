using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConsoleApp
{
    public class WaitingTime
    {
        private readonly int[] waitingTimes;

        public WaitingTime(int[] waitingTimes)
        {
            this.waitingTimes = waitingTimes;
        }

        // TODO: Implement this method is one of the challenge
        public TimeSpan Find(int index)
            => throw new NotImplementedException();
    }
}
