using Microsoft.Graph;
using Client.Services.Contracts;

namespace Client.Services.Implementations;

internal class OneDriveService : IOneDriveService
{
    public async Task CreateOneDriveFolder(string folderName, GraphServiceClient graphClient)
    {

        var newFolder = new DriveItem
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

        var response = await graphClient.Me.Drive.Root.Children.Request().AddAsync(newFolder);
    }
}
