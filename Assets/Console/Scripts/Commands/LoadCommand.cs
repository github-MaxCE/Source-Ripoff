using UnityEngine.SceneManagement;

/// <summary>
/// LOAD command. Load the specified scene by name.
/// </summary>
public static class LoadCommand
{
    public static readonly string name = "LOAD";
    public static readonly string description = "Load the specified scene by name. Before you can load a scene you have to add it to the list of levels used in the game. Use File->Build Settings... in Unity and add the levels you need to the level list there.";
    public static readonly string usage = "LOAD scene";
    public static string con(params string[] args)
    {
        if (args.Length == 0)
        {
            return HelpCommand.con(LoadCommand.name);
        }
        else
        {
            return LoadLevel(args[0]);
        }
    }
    private static string LoadLevel(string scene)
    {
        try
        {
            SceneManager.LoadScene(scene);
            return null;
        }
        catch
        {
            return string.Format("Failed to load {0}.", scene);
        }
    }
}