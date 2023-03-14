using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamsClient.Services.Contracts;

namespace TeamsClient.Services.Implementations;

internal class OneDriveService : IOneDriveService
{
    public async Task CreateOneDriveFolder(string folderName, GraphServiceClient graphClient)
    {

        var driveItem = new DriveItem
        {
            Name = folderName,
            Folder = new Folder
            {
            },
            AdditionalData = new Dictionary<string, object>()
            {
                {"@microsoft.graph.conflictBehavior", "rename"}
            }
        };

        await graphClient.Me.Drive.Root.Children
            .Request()
            .AddAsync(driveItem);
    }
}
