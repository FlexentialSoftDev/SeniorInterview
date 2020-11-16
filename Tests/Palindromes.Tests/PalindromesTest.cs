using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Palindromes.Tests
{
	[TestClass]
	public class PalindromesTest
	{
		[TestMethod]
		public void DetermineLargestPalindrome_IsPalindrome_ResultsInTrue()
		{
			string palindrome = "A man a plan a canal Panama";
			string notPalindrome = "This is some random text";

			Assert.IsTrue(PalindromesEngine.IsPalindrome(palindrome));
			Assert.IsFalse(PalindromesEngine.IsPalindrome(notPalindrome));
		}

		[TestMethod]
		public void DetermineLargestPalindrome_CountAllPalindromes_ResultsInX()
		{
			string test = "panama cat tacocat car lead was it a rat I saw racecar";

			List<string> palindromes = PalindromesEngine.GetPalindromes(test);

			Assert.AreEqual(3, palindromes.Count);
			Assert.AreEqual("tacocat", palindromes[0]);
			Assert.AreEqual("was it a rat I saw", palindromes[1]);
			Assert.AreEqual("racecar", palindromes[2]);
		}
	}
}
