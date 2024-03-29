﻿using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.Collections.Generic;

/// <summary>
/// Utility for caching and navigating recently executed console commands. 
/// </summary>
public class ConsoleInputHistory
{
    // Input history from most recent to oldest
    private List<string> inputHistory;
    public int maxCapacity = 200;
    // The go-to input entry index. The one to navigate to when first navigating up. It's usually the one most recently navigated-to.
    private int currentInput;
    private bool isNavigating;

    public int navigatevalue;

    private void Update() {
        if(Keyboard.current[Key.UpArrow].wasPressedThisFrame)
        {
            isNavigating = true;
            Navigate(1);
        }
        if(Keyboard.current[Key.DownArrow].wasPressedThisFrame)
        {
            isNavigating = true;
            Navigate(-1);
        }
        else
        {
            isNavigating = false;
            Navigate(0);
        }

    }

    public ConsoleInputHistory(int maxCapacity)
    {
        inputHistory = new List<string>(maxCapacity);
        this.maxCapacity = maxCapacity;
    }
    /// <summary>
    /// Navigates up or down the input history
    /// </summary>
    /// <returns>The navigated-to input entry</returns>
    public string Navigate(int navigation)
    {
        if (navigation == 1)
            currentInput++;
        if (navigation == -1)
            currentInput--;
        currentInput = Mathf.Clamp(currentInput, 0, inputHistory.Count - 1);
        // Return the navigated-to input entry
        if (isNavigating)
            return inputHistory[currentInput];
        else
            return "";
    }
    /// <summary>
    /// Add a new input entry to the input history.
    /// </summary>
    public void AddNewInputEntry(string input)
    {
        // Give the opportunity to "first" navigate up again, so that we can resume navigating up from the go-to input entry
        isNavigating = false;
        // Don't add the same input twice in a row
        if (inputHistory.Count > 0 && input.Equals(inputHistory[0], StringComparison.OrdinalIgnoreCase))
            return;
        // If we went over capacity, remove the oldest input entry to make room for a new one
        if (inputHistory.Count == maxCapacity)
            inputHistory.RemoveAt(maxCapacity - 1);
        
        // Insert the new input entry
        inputHistory.Insert(0, input);
        // If the go-to input entry was removed for capacity reasons, then the new input entry becomes go-to input entry
        if (currentInput == maxCapacity - 1)
            currentInput = 0;
        // Otherwise make sure the go-to input entry remains the same by shifting the index
        // Note that if there was no input entry before, then the go-to input entry index remains 0 which is the new input entry
        else
            currentInput = Mathf.Clamp(++currentInput, 0, inputHistory.Count - 1);
        
        // If the new input entry is different than the go-to input entry, then it becomes the go-to input entry
        if (!input.Equals(inputHistory[currentInput], StringComparison.OrdinalIgnoreCase))
            currentInput = 0;
    }
    public void Clear()
    {
        inputHistory.Clear();
        currentInput = 0;
        isNavigating = false;
    }
}