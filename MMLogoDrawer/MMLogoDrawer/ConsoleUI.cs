using System;
using System.Collections.Generic;
using System.Text;

namespace MMLogoDrawer
{
    class ConsoleUI : IUserInterface
    {
        public void Start()
        {
            try
            {
                MMLogoGenerator logo = new MMLogoGenerator();
                IValidator validator = new ThicknessParameterValidator();
                while (true)
                {
                    Console.Write("N = ");
                    int thicknessParameter = validator.Validate(Console.ReadLine());
                    logo.Generate(thicknessParameter);
                    Console.WriteLine(logo);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
