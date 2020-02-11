using System;

namespace MMLogoDrawer
{
    public class StartUp
    {
        public static void Main()
        {
            IUserInterface userInterface = new ConsoleUI();

            userInterface.Start();
        }    
    }
}
