using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company.Function;

public class Greet
{
    private readonly ILogger<Greet> _logger;

    public Greet(ILogger<Greet> logger)
    {
        _logger = logger;
    }

    [Function("Greet")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        string? name = req.Query["name"];

        if (string.IsNullOrWhiteSpace(name))
        {
            return new BadRequestObjectResult("Please pass a name on the query string, e.g. ?name=World");
        }

        const int maxNameLength = 100;
        if (name.Length > maxNameLength)
        {
            return new BadRequestObjectResult($"Name must be {maxNameLength} characters or fewer.");
        }

        return new OkObjectResult($"Hello, {name}! Welcome to Azure Functions!");
    }
}
