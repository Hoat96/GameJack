using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics.Internal;
using UnityEngine;
using UnityEngine.AI;

public class jack : MonoBehaviour
{
    public NavMeshAgent ai; // Jack AI
    public Transform player;
    Vector3 dest; // diem den cua AI â
    public float rotationSpeed = 10f;
   


    private void Awake()
    {
       ai = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {  
        
    }



    private void Update()
    {
        dest = player.position;// vi tri cua player
        ai.destination = dest;// diem den

        
    }
    
}
