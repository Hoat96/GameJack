using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public string sceneName; // level 2 scenename
    public int levelNumber;// so level

    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("level", levelNumber);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sceneName);
    }
}
