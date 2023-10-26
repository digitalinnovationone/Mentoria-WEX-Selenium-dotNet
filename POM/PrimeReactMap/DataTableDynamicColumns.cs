using OpenQA.Selenium;
using SeleniumCore;

namespace PrimeReactMap
{
	public class DataTableDynamicColumns : TestRunner
	{
		readonly string baseUrl = "https://primefaces.org/primereact-v5/#/datatable/selection";

		public new void Navigate(string page="")
		{
			if (string.IsNullOrEmpty(page))	TestRunner.Navigate(baseUrl);
			else TestRunner.Navigate(page);	
		}

		#region Mappers
		private static IWebElement UIDataTableRow => WebDriver.FindElement(By.XPath("//h5[text()='Single']/following-sibling::div/div/table/tbody/tr/td[text()='h456wer53']"));
		#endregion

		#region Actions
		public static string GetUIDataTableRow()
		{
			UIDataTableRow.Click();
			return UIDataTableRow.Text;
		}
		#endregion
	}
}