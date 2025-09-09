using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 offset = new Vector3(0, 0, 0); // Offset of camera for PlayerMovement
    // Start is called before the first frame update
  
    void LateUpdate()
    {
        
        transform.position = target.position + offset;
        transform.LookAt(target); // Looks at Player
    }
}
