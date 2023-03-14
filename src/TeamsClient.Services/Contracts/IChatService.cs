using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamsClient.Services.Contracts;

public interface IChatService
{
    Task<string> CreateChatAsync(string title, string[] userIds, GraphServiceClient graphClient);
}
