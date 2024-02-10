using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followpath : MonoBehaviour
{
    [SerializeField]
    public Transform[] Points;

    public int moveSpeed = 30;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[index].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (index <= Points.Length - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Points[index].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == Points[index].transform.position)
                index++;

            if(index == Points.Length)
            {
                index = 0;
            }
        }
    }
}
