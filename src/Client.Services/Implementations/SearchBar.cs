using Microsoft.Graph;
using Client.Services.Contracts;
using System.Threading.Tasks;

namespace Client.Services.Implementations;

internal class SearchBar : ISearchBar
{
    public async Task<IGraphServiceUsersCollectionPage> FindUser(string UserName, GraphServiceClient graphClient)
    {
        var filterString = $"startsWith(displayName, '{UserName}')";
        var queryOptions = new List<QueryOption>()
        {
            new QueryOption("$filter", filterString)
        };

       return await graphClient.Users.Request(queryOptions).GetAsync();
    }
}
