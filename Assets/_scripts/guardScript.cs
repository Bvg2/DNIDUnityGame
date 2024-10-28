using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardScript : MonoBehaviour
{
    public Transform[] waypoints;

    public float moveSpeed = 2f;

    private int waypointIndex;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = waypoints[waypointIndex].transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        if(transform.position == waypoints[waypointIndex].transform.position)
        {
            print("hit");
            waypointIndex = (waypointIndex + 1) % 4;
            transform.Rotate(Vector3.forward * -90);
        }
    }

}
