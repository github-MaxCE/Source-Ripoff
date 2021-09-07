public delegate string ConsoleCommandCallback(params string[] args);
public struct ConsoleCommand 
{
    public string name { get; private set; }
    public string description { get; private set; }
    public string usage { get; private set; }
    public ConsoleCommandCallback callback { get; private set; }
    public object value { get; private set;}
    public ConsoleCommand(string name, string description, ConsoleCommandCallback callback) : this()
    {
        this.name = name;
        this.description = (string.IsNullOrEmpty(description.Trim()) ? "No description provided" : description);
        this.callback = callback;
    }
    public ConsoleCommand(string name, string description, ConsoleCommandCallback callback, object value) : this()
    {
        this.name = name;
        this.description = (string.IsNullOrEmpty(description.Trim()) ? "No description provided" : description);
        this.callback = callback;
        this.value = value;
    }
}