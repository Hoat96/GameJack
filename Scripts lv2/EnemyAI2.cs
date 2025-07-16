using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics.Internal;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI2 : MonoBehaviour
{
    public NavMeshAgent AI;
    public Animator aiAnim;//animator 
    int randomNum;
    public Transform aiTrans, playerposition, randDest1, randDest2, randDest3, randDest4, randDest5, randDest6, randDest7, randDest8;
    public bool walking,idle,chasing;
    Vector3 dest;
  
    public float idleTime,chaseTime;
    public Collider lookerTrigger;
  


    private void Awake()
    {
        aiAnim = GetComponent<Animator>();
        AI = GetComponent<NavMeshAgent>();

    }

    private void Start()
    {
        walking = true;
        randomNum = UnityEngine.Random.Range(0, 8);
        aiAnim.SetTrigger("walk");
        if (randomNum == 0)
        {
            dest = randDest1.position;
        }
        if (randomNum == 1)
        {
            dest = randDest2.position;
        }
        if (randomNum == 3)
        {
            dest = randDest3.position;
        }
        if (randomNum == 4)
        {
            dest = randDest4.position;
        }
        if (randomNum == 5)
        {
            dest = randDest5.position;
        }
        if (randomNum == 6)
        {
            dest = randDest6.position;
        }
        if (randomNum == 7)
        {
            dest = randDest7.position;
        }
        if (randomNum == 8)
        {
            dest = randDest8.position;

        }
       
    }
    private void Update()
    {
        
        if (walking == true)
        {
            
            AI.destination= dest;
            AI.speed = 1;
           
        }
        if (chasing == true)
        {
            dest = playerposition.position;
            AI.destination = dest;
            AI.speed = 3;
        }

        if (idle == true)
        {
            AI.speed = 0;
        }
        // Trong hàm Update()
        if (!AI.pathPending && AI.remainingDistance <= AI.stoppingDistance)
        {
            // Agent đã đến nơi, đi đến điểm tiếp theo
            nextDest();
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chasing = true;
            walking = false;
            idle = false;
            aiAnim.ResetTrigger("idle");
            aiAnim.ResetTrigger("walk");
            aiAnim.SetTrigger("run");
            StopCoroutine("nextDest");
            StopCoroutine("chase");
            StartCoroutine("chase");
        }

        if (other.CompareTag("destination"))
        {
            idle = true;
            walking = false;
            aiAnim.ResetTrigger("walk");
            aiAnim.SetTrigger("idle");
            StartCoroutine(nextDest());
        }
       

    }

    IEnumerator nextDest()
    {
        yield return new WaitForSeconds(idleTime);
        idle = false;
        walking = true;
        aiAnim.ResetTrigger("idle");
        aiAnim.SetTrigger("walk");
        randomNum = UnityEngine.Random.Range(0, 8);
        if (randomNum == 0)
        {
            dest = randDest1.position;
        }
        if (randomNum == 1)
        {
            dest = randDest2.position;
        }
        if (randomNum == 3)
        {
            dest = randDest3.position;
        }
        if (randomNum == 4)
        {
            dest = randDest4.position;
        }
        if (randomNum == 5)
        {
            dest = randDest5.position;
        }
        if (randomNum == 6)
        {
            dest = randDest6.position;
        }
        if (randomNum == 7)
        {
            dest = randDest7.position;
        }
        if (randomNum == 8)
        {
            dest = randDest8.position;
        }

    }
    IEnumerator chase()
    {
       

        yield return new WaitForSeconds(chaseTime);
        chasing = false;
        walking = true;
        aiAnim.ResetTrigger("idle");
        aiAnim.ResetTrigger("run");
        aiAnim.SetTrigger("walk");
        randomNum = UnityEngine.Random.Range(0, 8);
        if (randomNum == 0)
        {
            dest = randDest1.position;
        }
        if (randomNum == 1)
        {
            dest = randDest2.position;
        }
        if (randomNum == 3)
        {
            dest = randDest3.position;
        }
        if (randomNum == 4)
        {
            dest = randDest4.position;
        }
        if (randomNum == 5)
        {
            dest = randDest5.position;
        }
        if (randomNum == 6)
        {
            dest = randDest6.position;
        }
        if (randomNum == 7)
        {
            dest = randDest7.position;
        }
        if (randomNum == 8)
        {
            dest = randDest8.position;
        }

    }
}
