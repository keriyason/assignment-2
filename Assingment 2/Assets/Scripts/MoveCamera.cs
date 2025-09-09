using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    //positiom of camera
    public Transform cameraPosition;
  
    void Update()
    {
        //Camera Follow Player without delay
        transform.position = cameraPosition.position;
        
    }
}
