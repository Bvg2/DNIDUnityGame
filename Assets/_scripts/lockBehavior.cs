using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockBehavior : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public bool ElephantOpened;
    public bool tigerOpened;
    public bool GiraffeOpened;
    public GameObject elephant;
    public GameObject armadillo;
    public GameObject giraffe;

    private GameObject spriteGiraffe;
    private GameObject spriteElephant;
    private GameObject spriteArmadillo;

    // Start is called before the first frame update
    void Start()
    {
        GiraffeOpened = false;
        tigerOpened = false;
        ElephantOpened = false;

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
                spriteArmadillo = GameObject.Find("npc_armadillo");
                Destroy(spriteArmadillo);

                tigerOpened = true;
                armadillo = Instantiate(armadillo);
                armadillo.transform.position = gameObject.transform.position;
                Destroy(gameObject);
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
                spriteGiraffe = GameObject.Find("npc_giraffe");
                Destroy(spriteGiraffe);
                GiraffeOpened = true;
                giraffe = Instantiate(giraffe);
                giraffe.transform.position = gameObject.transform.position;
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "player" && gotKeyElephant == true)
        {
            //collision.gameObject.GetComponent<playerMovement>().hasTigerKey = true;
            //get objects from different scrpits <> is the script :)
            if (gameObject.tag == "elephantLock")
            {
                spriteElephant = GameObject.Find("npc_elephant");
                Destroy(spriteElephant);
                ElephantOpened = true;
                elephant = Instantiate(elephant);
                elephant.transform.position = gameObject.transform.position;
                Destroy(gameObject);
            }
        }
    }
}
