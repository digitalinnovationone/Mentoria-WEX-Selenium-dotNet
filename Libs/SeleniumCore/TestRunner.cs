using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V115.SystemInfo;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCore
{
	[TestClass]
	public	class TestRunner
	{
		public TestContext TestContext { get; set; }
		protected WebDriverWait Wait;
		private static IWebDriver _driver;
		public static IWebDriver WebDriver => _driver;
		public static Browser Browser { get; set; }

		public static void Steps(string data)
		{
			Console.WriteLine();
			Console.WriteLine($"Step: {data}");
			Console.WriteLine($" *** Step Start Time: [{DateTime.Now.ToString("hh:mm:ss.FFF")}]");
		}

		public void Launch()
		{
			_driver = WebDriverFactory.CreateWebDriver(Browser);
			_driver.Manage().Window.Maximize();
			Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
			Console.WriteLine(TestContext);
		}
		public static void Navigate(string url)
		{
			Steps($"Navigating to: {url}");
			_driver.Navigate().GoToUrl(url);
		}

		[TestInitialize]
		public void TestSetup()
		{
			Console.WriteLine(" *******************************");
			Console.WriteLine(" *** Test Initialize");
		}

		[TestCleanup]
		public void TestCleanup()
		{
			_driver.Quit();
			Console.WriteLine();
			Console.WriteLine(" *******************************");
			Console.WriteLine(" *** Test Cleanup");
		}
	}
}
