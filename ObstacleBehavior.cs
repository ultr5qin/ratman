using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "MutantMouse")
        {
            if(gameManager.Items > 0)
            {
                gameManager.Items -= 1;
            }
        }
    }
}
