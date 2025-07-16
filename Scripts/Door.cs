using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject intText,key,lockedText;// doan text 
    public bool interactable ,toggle;// xd xem cua co the tuong tac hoac khong
    public Animator doorAnim;// hoạt động của Door

    private void Start()
    {
       
    }





    private void OnTriggerStay(Collider other)// player nhin thay cua thi true
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }
    private void OnTriggerExit(Collider other)// player khong thay thi false
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    private void Update()
    { 
        if(interactable == true)    // tuong tac voi cua                                              // player tuong tac voi cua va chia khoa
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(key.activeSelf == false)
                {
                    toggle = !toggle;
                    if (toggle == true)
                    {
                        doorAnim.ResetTrigger("close");
                        doorAnim.SetTrigger("open");
                        
                        
                        
                    }
                    if (toggle == false)
                    {
                        doorAnim.ResetTrigger("open");
                        doorAnim.SetTrigger("close");
                        
                       
                    }
                    intText.SetActive(false);
                    interactable = false;
                }
                if(key.activeSelf == true)
                {
                    lockedText.SetActive(true);
                    
                    StopCoroutine("disableText");
                    StartCoroutine("disableText");
                }
                
                
            }
        }
        

        
            
    }
    IEnumerator disableText()
    {
        yield return new WaitForSeconds(2.0f);
        lockedText.SetActive(false);
    }
}
