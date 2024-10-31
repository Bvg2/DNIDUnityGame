using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animalScript : MonoBehaviour
{
    private GameObject wayPoint;
    //public SpriteRenderer mySpriteRenderer;

    private Vector3 wayPointPos;
    public float speed = 6.0f;
    public bool follow = true;
    
    // Start is called before the first frame update
    void Start()
    {
        wayPoint = GameObject.Find("wayPoint");
    }

    // Update is called once per frame
    void Update()
    {
        


        if (follow)
        {
            wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
        }
        //mySpriteRenderer.flipX = body.velocity.x < 0f;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            //print("hit Player");
            follow = false;

        }
        if (collision.gameObject.tag == "follower")
        {
            //print("followerCollision");
            //follow = false;

        }
        if (collision.gameObject.tag == "enemy")
        {
            //Debug.Log("hit");
            SceneManager.LoadScene(1);
            //take you to a loss screen 

            //loss screen will reset the game. 


        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            //print("unHit");
            follow = true;

        }
        if (collision.gameObject.tag == "follower")
        {
            //print("followerCol");
            //follow = true;

        }
    }
}

