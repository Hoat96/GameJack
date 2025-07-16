using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausemenu, settingsmenu;
    public string sceneName;// ten cua menu scene
    public bool toggle;// xd khi nao game dung va khong
    public SC_FPSControllerscripts playerScript;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))// bat tat menu
        {
            toggle = !toggle;
            if (toggle == false)
            {
                pausemenu.SetActive(false);
                AudioListener.pause = false;
                Time.timeScale = 1;
                playerScript.enabled = true;// bat script cua player
                Cursor.visible = false; // an con tro chuot
                Cursor.lockState = CursorLockMode.Locked;// cho chuot o giua man hnh
            }
            
            if (toggle == true)
            {
                pausemenu.SetActive(true);
                AudioListener.pause = true;
                Time.timeScale = 0;
                playerScript.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
    public void toSettings()
    {
        pausemenu.SetActive(false);
        settingsmenu.SetActive(true);
    }
    public void backToPause()
    {
        pausemenu.SetActive(true);
        settingsmenu.SetActive(false);
    }
    public void resumeGame()
    {
        toggle = false;
        pausemenu.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1;
        playerScript.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void quitToMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(sceneName);
    }
    public void quitToDesktop()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        Debug.Log("the game will quit");
        Application.Quit();
    }
}
