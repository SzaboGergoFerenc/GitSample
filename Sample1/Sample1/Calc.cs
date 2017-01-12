using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class Calc : ICalc
    {

        public void Add()
        {
            Console.WriteLine("Add");
        }


        public void Div()
        {

        }

        public void DivD()
        {

        }

        public void Mult()
        {
            Console.WriteLine("Multi");
        }


        public void DivByZero()
        {

        }
    }
}
