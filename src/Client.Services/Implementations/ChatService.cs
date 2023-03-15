using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Services.Contracts;

namespace Client.Services.Implementations;

internal class ChatService : IChatService
{
    public async Task<string> CreateChatAsync(string title, string[] userIds, GraphServiceClient graphClient)
    {
        var members = new List<ConversationMember>();
        /*
        foreach (var id in userIds)
        {
            members.Append(new ConversationMember()
            {
                OdataType = "#microsoft.graph.aadUserConversationMember",
                Roles = new List<string>
                {
                    "owner",
                },
                AdditionalData = new Dictionary<string, object>
                {
                    {
                        "user@odata.bind" , $"https://graph.microsoft.com/v1.0/users('{id}')"
                    },
                },
            });
        }

        var requestBody = new Chat
        {
            ChatType = ChatType.Group,
            Topic = title,
            Members = members
        };

        var response = await graphClient.Chats.PostAsync(requestBody);
        */
        return " ";
    }
}
