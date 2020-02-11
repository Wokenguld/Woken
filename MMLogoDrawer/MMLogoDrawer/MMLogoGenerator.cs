using System;
using System.Collections.Generic;
using System.Text;

namespace MMLogoDrawer
{
    public class MMLogoGenerator:ILogoGenerator
    {
       private string logo;
        
        public string Logo
        {
            get
            {
                return this.logo;
            }
            
        }
        public void Generate(int thicknessParameter)
        {
            StringBuilder sbOfLogo = new StringBuilder();

            AppendFirstLine(thicknessParameter, sbOfLogo);
            AppendFirstInnerHalf(thicknessParameter, sbOfLogo);
            AppendSecondInnerHalf(thicknessParameter, sbOfLogo);
            AppendLastLine(thicknessParameter, sbOfLogo);

            this.logo = sbOfLogo.ToString();
                                   
        }
           
        private static void AppendFirstLine(int thiknessParameter, StringBuilder sbLine)
        {
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < 2; i++)
                {
                    sbLine.Append('-', thiknessParameter);
                    sbLine.Append('*', thiknessParameter);
                }
                sbLine.Append('-', thiknessParameter);
            }
            sbLine.Append("\n\r");
        }

        private static void AppendFirstInnerHalf(int thiknessParameter, StringBuilder sbOfLogo)
        {
            for (int i = 1; i <= (thiknessParameter - 1) / 2; i++)
            {
                for (int n = 0; n < 2; n++)
                {
                    sbOfLogo.Append('-', thiknessParameter - i);
                    sbOfLogo.Append('*', thiknessParameter + i * 2);
                    sbOfLogo.Append('-', thiknessParameter - i * 2);
                    sbOfLogo.Append('*', thiknessParameter + i * 2);
                    sbOfLogo.Append('-', thiknessParameter - i);
                }
                sbOfLogo.Append("\n\r");
            }
        }

        private static void AppendSecondInnerHalf(int thiknessParameter, StringBuilder sbOfLogo)
        {
            for (int i = 1; i <= (thiknessParameter - 1) / 2; i++)
            {
                for (int n = 0; n < 2; n++)
                {
                    sbOfLogo.Append('-', thiknessParameter / 2 - i + 1);
                    sbOfLogo.Append('*', thiknessParameter);
                    sbOfLogo.Append('-', i * 2 - 1);
                    sbOfLogo.Append('*', thiknessParameter * 2 - i * 2 + 1);
                    sbOfLogo.Append('-', i * 2 - 1);
                    sbOfLogo.Append('*', thiknessParameter);
                    sbOfLogo.Append('-', thiknessParameter / 2 - i + 1);
                }
                sbOfLogo.Append("\n\r");
            }
        }

        private static void AppendLastLine(int thiknessParameter, StringBuilder sbLine)
        {
            for (int n = 0; n < 2; n++)
            {
                for (int i = 0; i < 2; i++)
                {
                    sbLine.Append('*', thiknessParameter);
                    sbLine.Append('-', thiknessParameter);
                }
                sbLine.Append('*', thiknessParameter);
            }
            sbLine.Append("\n\r");
        }

        public override string ToString()
        {
            return this.logo;
        }
    }
}
