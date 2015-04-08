using System;

namespace ConsoleApplication1
{
    public class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;
        enum BatteryType { LiOH, NiMH, NiCd };

        public Battery()
        {
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.batteryType = BatteryType.LiOH;
        }

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursIdle = hoursIdle;
        }

        public override string ToString()
        {
            
            return string.Format("hoursIdle: {0}, hoursTalk: {1}, batteryModel: {2}", hoursIdle, hoursTalk, batteryType);
        }

    }
}
