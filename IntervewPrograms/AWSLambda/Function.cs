using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<User> FunctionHandler(Guid input, ILambdaContext context)
    {
        var dbcontext = new DynamoDBContext(new AmazonDynamoDBClient());
        var user = await dbcontext.LoadAsync<User>(input);
        return user;
    }
}

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
