using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JackJumscare : MonoBehaviour
{
    public Animator jackAnim; // animator cua jack
    public GameObject player; // object player
    public float jumscareTime; // thoi gian ket thuc canh doa nat
    public string sceneName;

    private void OnTriggerEnter(Collider other)// khi player gap Jack hoat anh doa nat se xuat hien va player tro lai death scene
    {
        if(other.CompareTag("Player"))
        {
            player.SetActive(false);
            jackAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());
        }
    }
    IEnumerator jumpscare()// dua player tro lai death scene
    {
        yield return new WaitForSeconds(jumscareTime);
        SceneManager.LoadScene(sceneName);
    }
}
