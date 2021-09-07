using UnityEngine;

/// <summary>
/// QUIT command. Quit the application.
/// </summary>
public static class QuitCommand
{
    public static readonly string name = "QUIT";
    public static readonly string description = "Quit the application.";
    public static readonly string usage = "QUIT";

    public static string con(params string[] args)
    {
        PlayerPrefs.DeleteKey("ran");
        Application.Quit();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
        return "Quitting...";
    }
}