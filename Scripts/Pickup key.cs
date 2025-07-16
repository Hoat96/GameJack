using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupkey : MonoBehaviour
{
    public GameObject inttext, key,spookystuff; // tuong tac voi van ban,den pin tren ban, den pin nguoi choi dang cam
    public AudioSource pickup;// nhac khi nhat len
    public bool interactable, scaryEvent;// xd xem player co nhin thay den pin ko va nhat len


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
                pickup.Play();
                if(scaryEvent == true)// khi nhat chia khoa scary Event xuat hien
                {
                    spookystuff.SetActive(true) ;
                }
                
                key.SetActive(false);
            }
        }
    }
}
