using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumbers;
using System.Collections.Generic;

namespace SeniorInterview.Tests
{
	[TestClass]
	public class PrimeNumbersTest
	{
		[TestMethod]
		public void CountOfPrimeNumbers_Under10Million_ResultsInX()
		{
			List<int> primeNumbers = PrimeNumbersEngine.GetAllUnder(10000000);

			Assert.AreEqual(348514, primeNumbers.Count);
			Assert.AreEqual(1, primeNumbers[0]);
			Assert.AreEqual(2, primeNumbers[1]);
			Assert.AreEqual(3, primeNumbers[2]);
			Assert.AreEqual(5, primeNumbers[3]);
			Assert.AreEqual(7, primeNumbers[4]);

			Assert.AreEqual(4999963, primeNumbers[348512]);
			Assert.AreEqual(4999999, primeNumbers[348513]);
		}
	}
}
