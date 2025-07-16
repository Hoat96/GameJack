using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginningCutscene : MonoBehaviour
{
    public GameObject cutsceneCam, player;// camera cat canh va object player
    public float cutsceneTime;// thoi gian cat canh

    private void Start() // camera cat canh, cho player xuat hien trong tro choi
    {
        StartCoroutine(cutscene());
    }
    IEnumerator cutscene()
    {
        yield return new WaitForSeconds(cutsceneTime);
        player.SetActive(true);
        cutsceneCam.SetActive(false);
    }
    
}
