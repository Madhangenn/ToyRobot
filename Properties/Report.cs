using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Report : ToyRobot
    {
        private static string displayReport;

        public static string DisplayReport
        {
            get { return displayReport; }
            set { displayReport = value; }
        }
    }
}
