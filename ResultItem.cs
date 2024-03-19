
using System;

namespace HeatTransfer
{
    public class ResultItem
    {
        public int time { get; set; }
        public int ballTemp { get; set; }

        public ResultItem(int time, int ballTemp)
        {
            this.ballTemp = ballTemp;
            this.time = time;
        }

        public override string ToString()
        {
            return this.time + "," + this.ballTemp;
        }
    }
}
