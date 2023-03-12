using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System.Text.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda;

public class Function
{
    private readonly DynamoDBContext dynamoDB;
    public Function()
    {
        dynamoDB = new DynamoDBContext(new AmazonDynamoDBClient());
    }

    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<APIGatewayHttpApiV2ProxyResponse> FunctionHandler(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        return request.RequestContext.Http.Method.ToUpper() switch
        {
            "GET" => await HandleGet(request),
            "POST" => await HandlePost(request),
            "DELETE" => await HandleDelete(request),
            _ => throw new NotImplementedException()
        };

    }

    private async Task<APIGatewayHttpApiV2ProxyResponse> HandleDelete(APIGatewayHttpApiV2ProxyRequest request)
    {
        request.PathParameters.TryGetValue("userId", out var userIdParameter);
        if (Guid.TryParse(userIdParameter, out var userId))
        {
            await dynamoDB.DeleteAsync<User>(userId);
            return Success();
        }
        else
        {
            return BadRequest("Invalid user id");
        }
    }

    

    private async Task<APIGatewayHttpApiV2ProxyResponse> HandlePost(APIGatewayHttpApiV2ProxyRequest request)
    {
        var user = JsonSerializer.Deserialize<User>(request.Body);
        if(user == null)
        {
            return BadRequest("Invalid user details");
        }
        await dynamoDB.SaveAsync(user);
        return Success();
        //return new APIGatewayHttpApiV2ProxyResponse
        //{
        //    StatusCode = 200,

        //};
    }

    private async Task<APIGatewayHttpApiV2ProxyResponse> HandleGet(APIGatewayHttpApiV2ProxyRequest request)
    {
        request.PathParameters.TryGetValue("userId", out var userIdParameter);
        if (Guid.TryParse(userIdParameter, out var userId))
        {
            //var dbcontext = new DynamoDBContext(new AmazonDynamoDBClient());
            var user = await dynamoDB.LoadAsync<User>(userId);
            return Success(user);
            //return new APIGatewayHttpApiV2ProxyResponse
            //{
            //    Body = JsonSerializer.Serialize(user),
            //    StatusCode = 200,
            //};
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
