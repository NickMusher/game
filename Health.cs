using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Health
    {
        public int Maximum { get; private set; }

        private int actual;
        public int Actual
        {
            get { return actual; }
            private set
            {
                if (value <= 0)
                {
                    Maximum = actual = 0;
                    return;
                }
                if (value > Maximum)
                {
                    actual = Maximum;
                    return;
                }
                actual = value;
            }
        }

        public Health(int health)
        {
            Maximum = health ;
            Actual = health;
        }
        

        public void DownOn(int damage)
        {
            Actual -= damage;
        }

        public void UpOn(int healing)
        {
            Actual += healing;
        }

        public bool IsDead()
        {
            return Maximum == 0;
        }
    }
}
