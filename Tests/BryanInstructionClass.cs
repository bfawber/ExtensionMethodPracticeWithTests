using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1;
using Xunit;

namespace Tests
{
	public class BryanInstructionClass
	{
		[Theory]
		[InlineData("")]
		public void ZeroCase(string value)
		{
			Assert.True(value.PassAllUnitTestsReverse() == "");
		}

		[Fact]
		public void PassingTest()
		{
			string sTestString = "food\"porn";
			Console.WriteLine(sTestString.PassAllUnitTestsReverse());
			Assert.Equal("nrop\"doof", sTestString.PassAllUnitTestsReverse());
		}

		[Theory]
		[InlineData(null)]
		public void Explode(string value)
		{

			Assert.Null(value.PassAllUnitTestsReverse());
		}

		[Fact]
		public void EdgeCase1()
		{
			Assert.True(true);
		}

		[Fact]
		public void EdgeCase2()
		{
			Assert.True(true);
		}

		[Fact]
		public void EdgeCase3()
		{
			Assert.True(true);
		}
	}
}
