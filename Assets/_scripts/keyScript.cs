using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    public Transform parent;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
        offset = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = parent.transform.TransformPoint(offset);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        bool keyStatus = col.gameObject.GetComponent<playerMovement>().hasNoKey;
        if (col.gameObject.tag == "player" && gameObject.tag == "tigerKey" && keyStatus == true)
        {
            print("tiger");
            transform.parent = col.transform;
            offset = Vector3.up * 2;
            GetComponent<Collider2D>().enabled = false;

        }
        if (col.gameObject.tag == "player" && gameObject.tag == "elephantKey" && keyStatus == true)
        {
            transform.parent = col.transform;
            offset = Vector3.up * 2;
            GetComponent<Collider2D>().enabled = false;

        }
        if (col.gameObject.tag == "player" && gameObject.tag == "giraffeKey" && keyStatus == true)
        {
            transform.parent = col.transform;
            offset = Vector3.up * 2;
            GetComponent<Collider2D>().enabled = false;


        }
        

    }
}
