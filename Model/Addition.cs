using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakV2.Model
{
    internal class Addition
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public Addition(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public Addition() { }

        public int saberi()
        {
            return num1 + num2;
        }
    }
}
