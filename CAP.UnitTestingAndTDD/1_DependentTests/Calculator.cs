using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP.UnitTestingAndTDD._1_DependentTests
{
    public class Calculator
    {
        private int Value { get; set; }

        public int Add(int valueToAdd)
        {
            Value += valueToAdd;
            return Value;
        }
    }
}
