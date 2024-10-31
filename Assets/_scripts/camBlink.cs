using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camBlink : MonoBehaviour
{
    public bool on;
    public float targetTime;
    float timer = 10f;
    

     

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > targetTime)
        {

            timer = 0;
            if (on)
            {
                //hide sprite     
                gameObject.GetComponent<Renderer>().enabled = false;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            else if (!on)
            {
                //show sprite
                gameObject.GetComponent<Renderer>().enabled = true;
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
            on = !on;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if(on == true)
            {
                //print("valid hit");
            }
        }
    }
}
