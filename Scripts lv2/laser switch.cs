using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserswitch : MonoBehaviour
{
    public Animator switchAnim;// animator switch
    public GameObject lasers, intText;// tia lasers chan loi ra
    public bool interactable, toggle;// xd khi nao player nhin vao cong tac hoac khong, xd khi nao player co the tuong tac voi cong tac hoac ko

    // neu toggle bang false va player nhin vao cong tac, doan text se dc bat va interactable se = true
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            if(toggle == false)
            {
                intText.SetActive(true);
                interactable = true;
            }
        }
    }
    // neu player nhin cho khac intText se tat va interactable se bang false
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    // neu interactable bang true va player nhan E, hoat anh cong tac se chay va lasers se tat
    private void Update()
    {
        if(interactable == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                switchAnim.SetTrigger("press");
                lasers.SetActive(false);
                intText.SetActive(false);
                toggle = true;
                interactable = false;

            }
        }
    }
}
