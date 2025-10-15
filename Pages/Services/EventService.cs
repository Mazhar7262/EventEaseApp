using EventEaseApp.Models;

public class EventService
{
    public List<EventModel> GetEvents() => new()
    {
        new EventModel { EventName = "Tech Conference 2025", EventDate = new DateTime(2025, 11, 5), Location = "London, UK" },
        new EventModel { EventName = "Startup Meetup", EventDate = new DateTime(2025, 12, 12), Location = "Manchester, UK" },
        new EventModel { EventName = "AI Expo", EventDate = new DateTime(2026, 1, 20), Location = "Birmingham, UK" }
    };
}
