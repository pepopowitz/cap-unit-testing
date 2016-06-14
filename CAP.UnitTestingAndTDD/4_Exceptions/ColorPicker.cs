using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP.UnitTestingAndTDD._4_Exceptions
{
    public class ColorPicker
    {
        public string PickColor(string yourName)
        {
            if (yourName == null)
            {
                throw new ArgumentNullException("yourName");
            }

            return "red";
        }
    }
}
