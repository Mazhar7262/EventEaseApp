public class UserState
{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<string> RegisteredEvents { get; set; } = new();
}
