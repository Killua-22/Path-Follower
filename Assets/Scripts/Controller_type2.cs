using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller_type2 : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray moveToPos = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(moveToPos, out var hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
