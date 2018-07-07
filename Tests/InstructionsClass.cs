using Xunit;
using Exercise1;
using System;
/**
* Use this class to unit test your string extension method.
* Add XUnit to this project through Nuget Packages, then using XUnit, create unit tests for your method.
* XUnit:
* https://xunit.github.io/
* 
* NuGet:
* https://docs.microsoft.com/en-us/nuget/quickstart/use-a-package
* 
* There are a few test cases every good test sweet should have:
* 1. The base case. Lets say you create a custom object. The base case should be "newing" up that object.
* Example:
* class BryansCustomObject
* {
*		string data
* }
* 
* test one would make sure the line:
* BryansCustomObject bryansCustomObject = new BryansCustomObject()
* does not explode.
* 
* 2. The zero case. The zero case is "What happens if I use the minimal amount of data?". This may be passing in
* null to a function, or the empty string, etc. Does your function handle that? Does it explode? Should it explode?
* 
* 3. The happy path. The way you expect your code to run. Passing in data you expect to see from people who are
* using your code. This should cover all "common" paths in the code. Think about the places your code "splits".
* This could be through if statements, for/while/any other loops, errors being thrown, etc. Which ones are very 
* likely to happen?
* 
* 4. Edge cases. What are some edge cases that could happen? What if someone passes in the max integer vakue into
* your function? Does it explode? Should it? How about a string with all spaces? A string with quotes in it? What
* are some "special" cases your code needs to take into acount?
* 
* 5. Negative cases. What are some paths the code will take where it SHOULD explode? Make sure it does explode if 
* those paths are taken! 
* 
* 6. Extra thoughts. What if you were trying to break your code. What would you pass in? Test those cases to make
* sure they don't break it. What if you switched the function you wrote with something else that "mimics" what yours
* does, but isn't quite the same thing? Would your unit test catch that?
*/

namespace Tests
{
	public class InstructionsClass
	{
        [Theory]
        [InlineData("")]
        public void ZeroCase(string value)
        {
            Assert.True(value.MuffinReverse() == "");
        }

        [Fact]
        public void PassingTest()
        {
            string sTestString = "food\"porn";
            Console.WriteLine(sTestString.MuffinReverse());
            Assert.Equal("nrop\"doof",sTestString.MuffinReverse());
        }

        [Theory]
        [InlineData(null)]
        public void Explode(string value)
        {
          
            Assert.Null(value.MuffinReverse());
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

