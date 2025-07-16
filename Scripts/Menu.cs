using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject loadingscreen, menuObj,settingsObj,controlsObj;// load scene
    public string sceneName, sceneName2;// ten scene 
    public Button continueButton;

   

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()// PlayerPrefs bang 0 nut continue se tat
    {
        if(PlayerPrefs.GetInt("level") == 0)
        {
            continueButton.interactable = false;
        }

    }

    public void playGame()
    {
        loadingscreen.SetActive(true); // load game
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sceneName);
    }
    public void continueGame()
    {
        loadingscreen.SetActive(true);
        if(PlayerPrefs.GetInt("level", 2) == 2)
        {
            SceneManager.LoadScene(sceneName2);
        }
        if (PlayerPrefs.GetInt("level", 1) == 1)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    //khi player an nut settings, settings menu se bat va main menu se tat
    public void SettingMenu()
    {
        menuObj.SetActive(false);
        settingsObj.SetActive(true);
    }
    public void ControlsMenu()
    {
        menuObj.SetActive(false);
        controlsObj.SetActive(true);
    }
    public void quitGame()// player quit game 1 bang se hien ra
    {
        Debug.Log("This will quit the game, only works in actual build,not in Unity editor.");
        Application.Quit();
    }
    // khi player an nut back settins menu , settings menu se tat va main menu se bat
    public void backToMenu()
    {
        settingsObj.SetActive(false);
        controlsObj.SetActive(false);
        menuObj.SetActive(true);
    }
    
                            
}
