public class AttendanceService
{
    private Dictionary<string, List<string>> attendance = new();

    public void Register(string eventName, string userEmail)
    {
        if (!attendance.ContainsKey(eventName))
            attendance[eventName] = new List<string>();

        if (!attendance[eventName].Contains(userEmail))
            attendance[eventName].Add(userEmail);
    }

    public List<string> GetAttendees(string eventName) =>
        attendance.ContainsKey(eventName) ? attendance[eventName] : new();
}
