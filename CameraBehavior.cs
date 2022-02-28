using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Transform target;
    public Vector3 camOffset;
 
    void LateUpdate () 
    {
        this.transform.position = target.position + camOffset;
        
        this.transform.LookAt(target);
    }
}
