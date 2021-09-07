using System.Text;

/// <summary>
/// HELP command. Display the list of available commands or details about a specific command.
/// </summary>
public static class HelpCommand
{
    public static readonly string name = "HELP";
    public static readonly string description = "Display the list of available commands or details about a specific command.";
    public static readonly string usage = "HELP [command]";

    private static StringBuilder commandList = new StringBuilder();

    public static string con(params string[] args)
    {
        if (args.Length == 0)
        {
            return DisplayAvailableCommands();
        }
        else
        {
            return DisplayCommandDetails(args[0]);
        }
    }

    private static string DisplayAvailableCommands()
    {
        commandList.Length = 0; // clear the command list before rebuilding it
        commandList.Append("<b>Available Commands</b>\n");

        foreach (ConsoleCommand command in ConsoleCommandsDatabase.commands)
        {
            if(command.value == null)
                commandList.Append(string.Format("        {0}\n        <color=red><b>Description:</b></color> {1}\n\n", command.name, command.description));
            else
                if(command.value.GetType() == typeof(bool))
                    commandList.Append(string.Format("        {0} is {1}\n        <color=red><b>Description:</b></color> {2}\n\n", command.name, ((bool)command.value? "ON" : "OFF"), command.description));
                else
                    commandList.Append(string.Format("        {0} = \"{1}\"\n        <color=red><b>Description:</b></color> {2}\n\n", command.name, command.value, command.description));
        }

        commandList.Append("To display details about a specific command, type 'HELP' followed by the command name.");
        return commandList.ToString();
    }

    private static string DisplayCommandDetails(string commandName)
    {
        string formatting1 = "        {0} is {1}\n        <color=red><b>Description:</b></color> {2}\n\n";
        string formatting2 = "        {0} = \"{1}\"\n        <color=red><b>Description:</b></color> {2}\n\n";

        try
        {
            ConsoleCommand command = ConsoleCommandsDatabase.GetCommand(commandName);
            if(command.value.GetType() == typeof(bool))
                return string.Format(formatting1, command.name, command.value, command.description);
            else
                return string.Format(formatting2, command.name, command.value, command.description);
        }
        catch (NoSuchCommandException exception)
        {
            return string.Format("Cannot find help information about {0}. Are you sure it is a valid command?", exception.command);
        }
    }
}