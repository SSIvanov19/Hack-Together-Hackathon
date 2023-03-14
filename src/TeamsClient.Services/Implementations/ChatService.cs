using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamsClient.Services.Contracts;

namespace TeamsClient.Services.Implementations;

internal class ChatService : IChatService
{
    public async Task<string> CreateChatAsync(string title, string[] userIds, GraphServiceClient graphClient)
    {
        var members = new ChatMembersCollectionPage();

        foreach (var id in userIds)
        {
            members.Append(new AadUserConversationMember()
            {
                Roles = new List<String>()
                {
                    "owner"
                },
                AdditionalData = new Dictionary<string, object>()
                {
                    {"user@odata.bind", $"https://graph.microsoft.com/v1.0/users('{id}')"}
                }
            });
        }

        var chat = new Chat
        {
            ChatType = ChatType.Group,
            Topic = title,
            Members = members
        };

        var response = await graphClient.Chats
            .Request()
            .AddAsync(chat);

        return response.Id;
    }
}
