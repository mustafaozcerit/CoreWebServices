using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsServiceHosting;

namespace WindowsServiceHosting
{
    public class Timer
    {

        private System.Timers.Timer timer;

        DateUpdateContoller dateUpdateContoller=new  DateUpdateContoller();

        public void Control()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 300;   //86400
            this.timer.AutoReset = true;
            this.timer.Start();
            dateUpdateContoller.Update();
        }
    }
}
