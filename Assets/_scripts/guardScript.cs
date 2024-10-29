using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardScript : MonoBehaviour
{
    public Transform[] waypoints;

    public float moveSpeed = 2f;
    public SpriteRenderer mySpriteRenderer;
    //Vector3 point;
    public float rotation = 4.5f;
    Vector3 axis = new Vector3(0, 0, 1);

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
            transform.Find("kidBeam").transform.RotateAround((new Vector3(transform.position.x + rotation, transform.position.y, 0)), axis, 90f);
            //GetComponentInChildren<Transform>().transform.Rotate(Vector3.forward * -90);
            //transform.Rotate(Vector3.forward * -90);
            if (waypointIndex == 2)
            {
                mySpriteRenderer.flipX = true;
            }
            if (waypointIndex == 0)
            {
                mySpriteRenderer.flipX = false;
            }


        }
    }

}
