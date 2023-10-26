using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCore
{
	public class WebDriverFactory
	{
		public static IWebDriver CreateWebDriver(Browser browser)
		{
			return browser switch
			{
				Browser.Edge => new EdgeDriver(),
				Browser.Chrome => new ChromeDriver(),
				Browser.Firedfox => new FirefoxDriver(),
				_ => throw new NotSupportedException(),
			};
		}
	}
}
