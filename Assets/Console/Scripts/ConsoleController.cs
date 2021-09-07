using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// The behavior of the console.
/// </summary>
[DisallowMultipleComponent]
[RequireComponent(typeof(ConsoleController))]
public class ConsoleController : MonoBehaviour
{
    public ConsoleUI ui;
    void Awake()
    {
        /* This instantiation causes a bug when Unity rebuilds the project while in play mode
           Solution: move it to class level initialization, and make inputHistoryCapacity a const */
        //inputHistory = new ConsoleInputHistory(inputHistoryCapacity); 
    }
    void OnEnable()
    {
        Console.OnConsoleLog += ui.AddNewOutputLine;
        ui.onSubmitCommand += execute.ExecuteCommand;
        ui.onClearConsole += execute.inputHistory.Clear;
    }
    void OnDisable()
    {
        Console.OnConsoleLog -= ui.AddNewOutputLine;
        ui.onSubmitCommand -= execute.ExecuteCommand;
        ui.onClearConsole -= execute.inputHistory.Clear;
    }
    public void oConsole(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) { return; }
        ui.ToggleConsole();
    }
    public void oPause(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) { return; }
        ui.CloseConsole();
    }
    private void NavigateInputHistory(bool up)
    {
        string navigatedToInput = execute.inputHistory.Navigate(1);
        ui.SetInputText(navigatedToInput);
    }
}

public static class execute
{
    public static ConsoleInputHistory inputHistory = new ConsoleInputHistory(inputHistoryCapacity);

    private const int inputHistoryCapacity = 300;

    public static ConsoleUI ui;

    public static void ExecuteCommand(string input)
    {
        input = input.Trim(' ');
        string[] parts = input.Split(' ');
        string command = parts[0];
        string[] args = parts.Skip(1).ToArray();
        for(var i = 0; i < args.Length; i++)
        {
            args[i] = args[i].Trim('\"');
        }
    
        Console.Log("] " + input);
        Console.Log(ConsoleCommandsDatabase.ExecuteCommand(command, args));
        inputHistory.AddNewInputEntry(input);
        ui.ClearInput();
        ui.StartCoroutine(ui.minscroll());
        DefaultCommands.regcom();
    }

    public static void ExecuteCommand(string input, bool nolog = false)
    {
        input = input.Trim(' ');
        string[] parts = input.Split(' ');
        string command = parts[0];
        string[] args = parts.Skip(1).ToArray();

        Console.Log(ConsoleCommandsDatabase.ExecuteCommand(command, args));
        DefaultCommands.regcom();
    }
}