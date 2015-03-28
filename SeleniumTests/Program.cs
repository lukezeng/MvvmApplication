using OpenQA.Selenium.Firefox;

namespace SeleniumTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.baidu.com");
            driver.Close();
        }
    }
}
