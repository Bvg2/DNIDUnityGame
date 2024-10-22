using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockBehavior : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public bool opened; 
    // Start is called before the first frame update
    void Start()
    {
        opened = false;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        bool gotKeyTiger = collision.gameObject.GetComponent<playerMovement>().hasTigerKey;
        bool gotKeyGiraffe = collision.gameObject.GetComponent<playerMovement>().hasGiraffeKey;
        bool gotKeyElephant = collision.gameObject.GetComponent<playerMovement>().hasElephantKey;
        if (collision.gameObject.tag == "player" && gotKeyTiger == true)
        {
            if (gameObject.tag == "tigerLock")
            {
                spriteRenderer.sprite = newSprite;
                opened = true;
            }
            //collision.gameObject.GetComponent<playerMovement>().hasTigerKey = true;
            //get objects from different scrpits <> is the script :)
            //spriteRenderer.sprite = newSprite;
        }
        if (collision.gameObject.tag == "player" && gotKeyGiraffe == true)
        {
            //collision.gameObject.GetComponent<playerMovement>().hasTigerKey = true;
            //get objects from different scrpits <> is the script :)
            if (gameObject.tag == "giraffeLock")
            {
                spriteRenderer.sprite = newSprite;
                opened = true;
            }
        }
        if (collision.gameObject.tag == "player" && gotKeyElephant == true)
        {
            //collision.gameObject.GetComponent<playerMovement>().hasTigerKey = true;
            //get objects from different scrpits <> is the script :)
            if (gameObject.tag == "elephantLock")
            {
                spriteRenderer.sprite = newSprite;
                opened = true;
            }
        }
    }
}
