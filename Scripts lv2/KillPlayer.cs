using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public EnemyAI2 monsterscript;
    public string sceneDeath;
    public AudioClip audiokill;
    private AudioSource audioSource;
    public Camera cameraplayer;
    public Camera killcamera;
    
    

    private void Awake()
    {
        audioSource= GetComponent<AudioSource>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           
            monsterscript.enabled= false;
            animator.ResetTrigger("idle");
            animator.ResetTrigger("walk");
            animator.ResetTrigger("run");
            animator.SetTrigger("attack");
            cameraplayer.gameObject.SetActive(false);
            killcamera.gameObject.SetActive(true);
            audioSource.PlayOneShot(audiokill);


            //player.SetActive(false);
            player.GetComponent<SC_FPSControllerscripts>().enabled = false; // Tắt script điều khiển
            player.GetComponent<MeshRenderer>().enabled = false; // Ẩn model
            StartCoroutine(deathkill());
        }
    }
    IEnumerator deathkill()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneDeath);
       
        
    }
}
