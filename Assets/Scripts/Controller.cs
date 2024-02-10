using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    
    public Transform[] points;

    [SerializeField]
    public int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(index == points.Length)
        {
            index = 0;
        }

        if (transform.position.x == points[index].transform.position.x && transform.position.z == points[index].transform.position.z)
        {
            Debug.Log("Reached");
            index++;

            // Check if there are more points to move to
            if (index < points.Length)
            {
                agent.SetDestination(points[index].transform.position);
            }

            
        }

        // Move to the next destination if there are more points to visit
        if (Input.GetKeyDown(KeyCode.Space) && index < points.Length)
        {
            agent.SetDestination(points[index].transform.position);
        }



    }
}
