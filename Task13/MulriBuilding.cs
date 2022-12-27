using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    sealed class MulriBuilding : Building
    {
        int floors;

        public MulriBuilding(string adress, double length, double width, double hight, int floors)
            : base(adress, length, width, hight)
        {
            this.Floors = floors;
        }
        public int Floors
        {
            get { return floors; }
            set
            {
                if (value < 0)
                {
                    floors = -value;
                }
                else if (value == 0)
                {
                    floors = 1;
                }
                else
                {
                    floors = value;
                }
            }
        }
        public string Print()
        {
            string result = base.Print();
            result += $", этажей: {floors}";
            return result;
        }
    }
}
