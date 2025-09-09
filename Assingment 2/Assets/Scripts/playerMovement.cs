using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float floatAmplitude = 0.5f; // Player floats and bobs up and down
    public float floatFrequency = 2f; // How fast Player floats and bobs
   
    
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; // Starting position relative to bobbing 
        
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        Vector3 bobbingPos = new Vector3(transform.position.x, newY, transform.position.z);
        transform.position = bobbingPos; // Bobbing up and down movement


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0, v); // Player Movement

        transform.Translate(move * speed * Time.deltaTime, Space.Self);
        
    }
}
