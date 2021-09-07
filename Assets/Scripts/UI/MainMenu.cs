using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    Resolution[] resolutions;
    public Camera m_Camera;
    public Toggle fullscreenToggle;
    public Dropdown resolutionDropdown;
    public Dropdown qualityDropdown;
    public InputActionAsset inputActionAsset;

    public Settings settings;


    void Update()
    {
        settings.refreshfield();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        DefaultCommands.regcom();
        Settings.m_Path = Directory.GetCurrentDirectory() + "/Config";
        if (!Directory.Exists(Settings.m_Path))
        {
            Directory.CreateDirectory(Settings.m_Path);
        }
        else{
            execute.ExecuteCommand("exec autoexec.cfg",true);
        }
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        int currentResolutionIndex = 0;
        List<string> options = new List<string>();
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == m_Camera.pixelWidth &&
                resolutions[i].height == m_Camera.pixelHeight)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        qualityDropdown.value = QualitySettings.GetQualityLevel();
        qualityDropdown.RefreshShownValue();
        
        fullscreenToggle.isOn = Screen.fullScreen;
    }

    public void setResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}