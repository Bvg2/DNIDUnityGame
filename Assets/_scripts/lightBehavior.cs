using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBehavior : MonoBehaviour
{
    // Start is called before the first frame 
    public Transform beam;
    public float rotaion;
    public float speed;
    public float bounds;
    float posX;
    float posY;
    float stopper;
    bool up;
    Vector3 point;
    Vector3 axis = new Vector3(0, 0, 1);
    void Start()
    {
        stopper = 0;
        posX = gameObject.transform.position.x;
        posY = gameObject.transform.position.y;
        point = new Vector3(posX + rotaion, posY, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (!up)
        {
            transform.RotateAround(point, axis, Time.deltaTime * speed);
        }
        else
        {
            transform.RotateAround(point, axis, -Time.deltaTime * speed);
        }
        

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "waypoint")
        {
            Debug.Log("hit");
            up = !up;
        }
    }
}
