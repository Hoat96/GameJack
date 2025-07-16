using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupflashlight : MonoBehaviour
{
    public GameObject inttext, flashlight_table, flashlight_hand; // tuong tac voi van ban,den pin tren ban, den pin nguoi choi dang cam
    public AudioSource pickup;// nhac khi nhat len
    public bool interactable;// xd xem player co nhin thay den pin ko va nhat len

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))// player nhin thay den pin va doan text hien len
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))// player dung o xa va ko the cam den pin len
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }
    private void Update()
    {
        if(interactable == true)// khi interactable bang true thi player co the cam den len
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                inttext.SetActive(false) ;
                interactable = false ;
                //picup.Play();
                flashlight_hand.SetActive(true);
                flashlight_table.SetActive(false);
            }
        }
    }
}
