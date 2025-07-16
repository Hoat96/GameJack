using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonJack : MonoBehaviour
{
    public GameObject Jack,block1,block2;
    public Collider collision;
    public bool blocks;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Jack.SetActive(true);
            if (blocks == true)
            {
                block1.SetActive(true);
                block2.SetActive(true);
                
            }
            collision.enabled = false;
        } 

    }
}
