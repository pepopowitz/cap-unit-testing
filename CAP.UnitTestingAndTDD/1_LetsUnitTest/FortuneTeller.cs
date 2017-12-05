using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP.UnitTestingAndTDD._1_LetsUnitTest
{
    public class FortuneTeller
    {
        public string TellFortune(string yourName)
        {
            if (string.IsNullOrWhiteSpace(yourName))
            {
                return NoFuture;
            }

            if (yourName.Length == 5)
            {
                if (yourName.StartsWith("S"))
                {
                    return Awesome;
                }
                return LiveForever;
            } else if (yourName.Length == 9)
            {
                return LongName;
            }

            return Mediocre;
        }

        public const string NoFuture = "You have no future";
        public const string Mediocre = "You are destined for mediocrity.";
        public const string Awesome = "You are awesome and everyone likes you!";
        public const string LiveForever = "May you live to be a thousand years old.";
        public const string LongName = "May your life be as long as your name.";
    }
}
