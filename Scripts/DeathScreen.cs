using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public string SceneName;
    public float waitTime;// time khi tro lai scene

    private void Start()
    {
        StartCoroutine(loadToMenu());
    }
    IEnumerator loadToMenu()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneName);
    }
}
