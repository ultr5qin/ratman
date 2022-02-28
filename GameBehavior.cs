using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public int minCheeses;

    public bool darwin = false;
    public bool winScreen = false;
    public bool looseScreen = false;

    private int cheeseCollected = 0;
    public int timeRemaining;

    public int Items
    {
        get {return cheeseCollected;}

        set {cheeseCollected = value;

            if(cheeseCollected >= minCheeses)
            {
                darwin = true;
            }
            if(cheeseCollected < minCheeses)
            {
                darwin = false;
            }
        }
    }


    void Update()
    {
        TimeConditions();

    }
    void FixedUpdate()
    {
        Physics.gravity = new Vector3(0, Physics.gravity.y - 2, 0);
    }

    void TimeConditions()
    {
        if(timeRemaining >= 1)
        {
            timeRemaining -= 1;
        }
        if(timeRemaining < 1)
        {
            Win();
        }
    }

    void Win()
    {
        if(darwin)
        {
            winScreen = true;
        }
        else
        {
            looseScreen = true;
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Cheeses Devoured:" + cheeseCollected);
        GUI.Box(new Rect(20, 50, 150, 25), "Time Remaining:" + timeRemaining);
        if(looseScreen)
        {
            if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You were euthanized."))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            }
        }
        if(winScreen)
        {
            if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You survived!"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
        }
    }
}
