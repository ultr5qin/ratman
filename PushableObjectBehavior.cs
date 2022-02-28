using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableObjectBehavior : MonoBehaviour
{
    //guided by https://adamwreed93.medium.com/how-to-make-pushable-objects-in-unity-ecd0fba5e9ea
    private float strength = 3f;

    void OnControllerColliderHit(ControllerColliderHit collision)
    {
        if(collision.gameObject.name == "MutantMouse")
        {
            Rigidbody easyBox = collision.collider.GetComponent<Rigidbody>();
            Vector3 newBoxLocation = new Vector3(collision.moveDirection.x, 0, collision.moveDirection.z);
            easyBox.velocity = newBoxLocation * strength;
        }
    }


}
