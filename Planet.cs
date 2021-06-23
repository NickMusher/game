using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Planet
    {
        private static readonly int max = 3;
        private static int type;
        public static int Type
        {
            get { return type; }
            set
            {
                if (value < 0) type = max - 1;
                if (value > max) type = 0;
                type = value;
            }
        }
    }
}
