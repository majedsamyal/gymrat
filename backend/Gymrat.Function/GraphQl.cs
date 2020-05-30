using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotChocolate.AzureFunctions;
using System.Threading;

namespace Gymrat.Function
{
    public class GraphQl
    {
        private readonly IGraphQLFunctions _graphQLFunctions;

        public GraphQl(IGraphQLFunctions graphQLFunctions)
        {
            _graphQLFunctions = graphQLFunctions;
        }

        [FunctionName("graphql")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log, CancellationToken cancellationToken)
        {
            return await _graphQLFunctions.ExecuteFunctionsQueryAsync(
                req.HttpContext,
                cancellationToken);
        }
    }
}
