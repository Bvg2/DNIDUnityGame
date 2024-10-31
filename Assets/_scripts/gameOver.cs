using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{

    public float timeLeft;

    private void Start()
    {
        
    }
    void Update()
    {
        timeLeft--;

        if (timeLeft < 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
