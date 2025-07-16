using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepsoundChange : MonoBehaviour
{
    public AudioSource footSource,footSource1;// audio nguon di bo va chay
    public AudioClip foot1, foot2, foot3, foot4;// audio chay va di bo khac nhau

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            footSource.enabled = false;
            footSource1.enabled = false;
            footSource.clip = foot3;
            footSource1.clip = foot4;
            footSource.enabled = true;
            footSource1.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            footSource.enabled = false;
            footSource1.enabled = false;
            footSource.clip = foot1;
            footSource1.clip = foot2;
            footSource.enabled = true;
            footSource1.enabled = true;
        }
    }
}
