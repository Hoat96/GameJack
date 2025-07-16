using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    
    public GameObject inttext, lights; // van ban tuong tac, vat nhe
    public bool toggle = true,interactable; // bool xd bong den co sang ko,bool xd player con nhin vao cong tac den khong
    public Renderer lightBulb; // trinh ket xuat cua bong den
    public Material offlight, onlight;// vat lieu cua bong den khi tat va bat
    public AudioSource lightSwicth;// nguon am thanh cua cong tac den
    public Animator switchAnim;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))// player nhin vao den pin thi set van ban thanh true
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("MainCamera"))// player nhin ra cho khac thi false
        {
            inttext.SetActive(false);
            interactable= false;
        }
    }
    private void Update()
    {
        if(interactable == true)// interactable la true player nhan E de bat cong tac den
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                switchAnim.ResetTrigger("press");
                switchAnim.SetTrigger("press");
            }
        }
        if(toggle == false)
        {
            lights.SetActive(false);
            lightBulb.material = offlight;
        }
        if (toggle == true)
        {
            lights.SetActive(true);
            lightBulb.material = onlight;
        }
    }
}
