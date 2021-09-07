using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// The interactive front-end of the console.
/// </summary>
[DisallowMultipleComponent]
[RequireComponent(typeof(ConsoleController))]
public class ConsoleUI : MonoBehaviour
{
    public event Action<string> onSubmitCommand;
    public event Action onClearConsole;
    public Scrollbar scrollbar;
    public Text outputText;
    public ScrollRect outputArea;
    public InputField inputField;
    public GameObject Panel;
    public Pausing pausing;

    /// <summary>
    /// Indicates whether the console is currently open or close.
    /// </summary>
    public bool isConsoleOpen { get { return enabled; } }
    /// <summary>
    /// Opens or closes the console.
    /// </summary>

    public void Awake()
    {
        Show(false);
    }

    public void ToggleConsole()
    {
        if(!pausing.isPaused)
            pausing.Pause();
        Show(!enabled);
    }
    /// <summary>
    /// Opens the console.
    /// </summary>
    public void OpenConsole()
    {
        if(!pausing.isPaused)
            pausing.Pause();
        Show(true);
    }
    /// <summary>
    /// Closes the console.
    /// </summary>
    public void CloseConsole()
    {
        Show(false);
    }
    public void Show(bool show)
    {
        Panel.SetActive(show);
        enabled = show;
    }
    /// <summary>
    /// What to do when the user wants to submit a command.
    /// </summary>
    public void OnSubmit(string input)
    {
        if (EventSystem.current.alreadySelecting) // if user selected something else, don't treat as a submit
            return;
        if (input.Length > 0)
        {
            if (onSubmitCommand != null)
                StartCoroutine(minscroll());
                ClearInput();
                inputField.ActivateInputField();
                onSubmitCommand(input);
                execute.ExecuteCommand(input);
        }
    }
    public void OnSubmitnolog(string input)
    {
        if (EventSystem.current.alreadySelecting) // if user selected something else, don't treat as a submit
            return;
        if (input.Length > 0)
        {
            if (onSubmitCommand != null)
                StartCoroutine(minscroll());
                ClearInput();
                inputField.ActivateInputField();
                execute.ExecuteCommand(input, true);
        }
    }
    void OnEnable()
    {
        inputField.ActivateInputField();
    }
    public IEnumerator minscroll()
    {
        scrollbar = GetComponentInChildren<Scrollbar>();
        yield return new WaitForSeconds(0.03f);
        scrollbar.value = 0;
    }
    /// <summary>
    /// What to do when the user uses the scrollwheel while hovering the console input.
    /// </summary>
    /// <summary>
    /// Displays the given message as a new entry in the console output.
    /// </summary>
    public void AddNewOutputLine(string line)
    {
        outputText.text += Environment.NewLine + line;
    }
    /// <summary>
    /// Clears the console output.
    /// </summary>
    public void ClearOutput()
    {
        outputText.text = "";
        outputText.SetLayoutDirty();
        if(onClearConsole != null)
            onClearConsole();
    }
    /// <summary>
    /// Clears the console input.
    /// </summary>
    public void ClearInput()
    {
        SetInputText("");
    }
    /// <summary>
    /// Writes the given string into the console input, ready to be user submitted.
    /// </summary>
    public void SetInputText(string input) 
    {
        inputField.text = input;
    }
}