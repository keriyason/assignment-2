using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Vector3 winPoint = new Vector3(-3.22f, 3.15f, -2.01f); // Position of "Win"

    public float winDistance = 2.0f; // Proximal Distance to "Win"

    public Transform player;
  
    void Update()
    {
        float distrancetoWin = Vector3.Distance(player.position, winPoint);

        if (distrancetoWin <= winDistance )
        {
            WinGame();
        }

        
    }
    void WinGame()
    {
        Debug.Log("YOU WIN!!!");
    }
}
