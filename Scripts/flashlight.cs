using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public GameObject lights;// den flash
    public bool toggle;// xd xem den pin khi nao bat va tat
    public AudioSource toggleSound;// am nhac den pin khi bat va tat

    private void Start()
    {
        if (toggle == false)
        {
            lights.SetActive(false);
        }
        if (toggle == true)
        {
            lights.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))// set bat tat den pin
        {
            toggle = !toggle;
            //toggleSound.Play();
            if(toggle == false)
            {
                lights.SetActive(false);
            }
            if (toggle == true)
            {
                lights.SetActive(true);
            }
        }
    }
}
