using Amazon.Lambda.TestUtilities;
using Xunit;

namespace AWSLambda.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {

        // Invoke the lambda function and confirm the string was upper cased.
        var function = new Function();
        var context = new TestLambdaContext();
        var upperCase = function.FunctionHandler(new User { Id=1, Name= "hello deepak" }, context);

        Assert.Equal("HELLO DEEPAK", upperCase);
    }
}
