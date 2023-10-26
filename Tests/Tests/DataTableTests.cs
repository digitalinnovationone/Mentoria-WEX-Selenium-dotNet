using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeReactMap;

namespace Tests
{
	[TestClass]
	public class DataTableTests : DataTableDynamicColumns
	{
		/// <summary>
		/// Search for the h456we53 code
		/// </summary>
		[TestMethod]
		[TestCategory("QA")]
		public void ReactSingleTable_DynamicTable_IsClicked()
		{
			#region Variables
			string code = "h456wer53";
			string text;
			#endregion

			Navigate();
			Steps($"Searching the {code}");
			text = GetUIDataTableRow();

			Steps($"Asserting {text} vs {code}");

			#region Assertions
			Assert.IsFalse(string.IsNullOrEmpty(text));
			Assert.AreEqual(code, text);
			#endregion
		}

		[TestInitialize]
		public void TestInitialize() 
		{
			Browser = SeleniumCore.Browser.Chrome;
			Launch();


		}
	}

}