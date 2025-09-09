using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 offset = new Vector3(0, 5, -7); // Offset of camera for PlayerMovement
    // Start is called before the first frame update
  
    void LateUpdate()
    {
        Vector3 rotatedOffset = target.rotation * offset;
        transform.position = target.position + rotatedOffset;
        transform.LookAt(target); // Looks at Player
    }
}
