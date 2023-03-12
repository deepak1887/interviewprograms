using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.Annotations;
using Amazon.Lambda.Annotations.APIGateway;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System.Text.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaAnotation;

public class Functions
{
    /// <summary>
    /// Default constructor that Lambda will invoke.
    /// </summary>
    private readonly DynamoDBContext dynamoDB;
    public Functions()
    {
        dynamoDB = new DynamoDBContext(new AmazonDynamoDBClient());
    }


    /// <summary>
    /// A Lambda function to respond to HTTP Get methods from API Gateway
    /// </summary>
    /// <param name="request"></param>
    /// <returns>The API Gateway response.</returns>
    [LambdaFunction]
    [HttpApi(LambdaHttpMethod.Get, "users/{userId}")]
    public async Task<APIGatewayHttpApiV2ProxyResponse> GetUser(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        //APIGatewayHttpApiV2ProxyRequest request
        request.PathParameters.TryGetValue("userId", out var userIdParameter);
        if (Guid.TryParse(userIdParameter, out var id))
        {
            var user = await dynamoDB.LoadAsync<User>(id);
            return Success(user);
        }
        else
        {
            return BadRequest("Invalid user id");
        }
    }

    private static APIGatewayHttpApiV2ProxyResponse BadRequest(string body)
    {
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = 404,
            Body = body
        };
    }

    private static APIGatewayHttpApiV2ProxyResponse Success(object? body = null)
    {
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = 200,
            Body = body != null ? JsonSerializer.Serialize(body) : null,
        };
    }
}

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
