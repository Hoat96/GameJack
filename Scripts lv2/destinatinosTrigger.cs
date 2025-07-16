using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destinatinosTrigger : MonoBehaviour
{
    public Collider collision;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("monster"))
        {
            StartCoroutine(reEnable());
            collision.enabled = false;
        }
    }
    IEnumerator reEnable()
    {
        yield return new WaitForSeconds(2.0f);
        collision.enabled = true;
    }
}
