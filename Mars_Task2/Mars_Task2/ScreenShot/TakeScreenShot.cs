using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task2.ScreenShot
{
    public class TakeScreenShot
    {

        
        
            public static void ScreenShotMethod(IWebDriver driver)
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile(@"C:\Users\teja.LAPTOP-JPPE5QFM\Desktop\Teja\Screenshot" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Jpeg);

            }

        
    }
}
