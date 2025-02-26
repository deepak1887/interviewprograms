using Amazon.Lambda.Core;
using Octokit;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaGitHub;

public class Function
{
    private static readonly string GitHubToken = "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";
    private static readonly string RepoOwner = "deepak1887";
    private static readonly string RepoName = "interviewprograms";
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input">The event for the Lambda function handler to process.</param>
    /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>
    public async Task<string> FunctionHandler(FileRequest request, ILambdaContext context)
    {
        var gitHub = new GitHubClient(new ProductHeaderValue("GitHubfilereader"))
        {
            Credentials = new Credentials(GitHubToken)
        };
        //var allContent = await gitHub.Repository.Content.GetAllContents(RepoOwner, RepoName);
        var fileContent = await gitHub.Repository.Content.GetAllContents(RepoOwner, RepoName, request.FilePath);

        //string decoded = Encoding.UTF8.GetString(Convert.FromBase64String(fileContent[0].Content));

        return fileContent[0].Content;
    }
}

public class FileRequest
{
    public string FilePath { get; set; } = string.Empty;
    public string? FolderName { get; set; }
    public string? FileName { get; set; }
}
