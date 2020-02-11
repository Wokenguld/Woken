using System;
using System.Collections.Generic;
using System.Text;

namespace MMLogoDrawer
{
    public class ThicknessParameterValidator:IValidator
    {
        public int Validate(string input)
        {
            int thicknessParameter;
            bool isInteger = int.TryParse(input, out thicknessParameter);
            if (isInteger)
            {
                if (2 < thicknessParameter && thicknessParameter < 10000 && thicknessParameter % 2 == 1)
                {
                    return thicknessParameter;
                }
                else
                {
                    throw new ArgumentException("The number must be odd and between 2 and 10 000");
                }
            }
            else
            {
                throw new ArgumentException("The thickness must be integer number.");
            }
        }
    }
}
