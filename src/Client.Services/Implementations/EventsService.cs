using Microsoft.Graph;
using Client.Services.Contracts;
using Client.Services.Contracts;
using Microsoft.Identity.Client;

namespace Client.Services.Implementations;

internal class EventsService : IEventsService
{

    public async Task<ICalendarEventsCollectionPage> GetMyEvents(GraphServiceClient graphClient)
    {
        // Retrieve all events from the user's calendar
        return await graphClient.Users["bf98dc19-3ec1-4258-a86b-b2f7e34f3ce0"].Calendar.Events.Request().GetAsync();
        /*
        // Create arrays to store the start and end times
        var startTimes = new DateTimeTimeZone[events.Count];
        var endTimes = new DateTimeTimeZone[events.Count];

        int i = 0;
        foreach (var ev in events)
        {
            // Store the start and end times in the arrays
            startTimes[i] = ev.Start;
            endTimes[i] = ev.End;

            Console.WriteLine($"Event name: {ev.Subject} | Start time: {startTimes[i].DateTime} | End time: {endTimes[i].DateTime}");
            i++;
        }
        /*
        double startDay = 7;
        double endDay = 20;

        double allDayTime = endDay - startDay;
        string currDay = "";

        for (int j = 0; j < startTimes.Length; j++)
        {
            currDay = startTimes[j].DateTime.Split("T")[0];
            //endTimes[i]
        }

        //_eventTimeService.CalculationEventTime(startTimes, endTimes);
        */
    }
}
