using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    public Transform player;
    public float distY;
    public float distZ;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, distY, -distZ);
    }
}
