using System;
using System.IO;
using Xunit;

namespace HelloWorldTest
{
    public class UnitTest1
    {
        private const string Expected = "Hello World!";

        [Fact]
        public void TestOutputIsHelloWorld()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.HelloWorld();

                var result = sw.ToString().Trim();
                Assert.Equal(Expected, result);
            }
        }
    }
}
