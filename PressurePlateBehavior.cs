using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateBehavior : MonoBehaviour
{
    void OnTriggerStay(Collider pressure)
    {
        if(pressure.gameObject.name == "Pushable Box")
        {
            Destroy(this.transform.gameObject);

            Destroy(GameObject.Find("Pushable Box").transform.gameObject);

        }
    }
}
