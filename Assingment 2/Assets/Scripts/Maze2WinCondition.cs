using UnityEngine;
using UnityEngine.SceneManagement;

public class Maze2WinCondition : MonoBehaviour
{
    public string nextSceneName = "Endcutscene"; // Scene to load after winning

// Position of the win point
public Vector3 winPoint = new Vector3(-1.33f, 3.7f, 2.01f);

// How close the player must be to trigger the win
public float winDistance = 2.0f;

// Reference to the player Transform
public Transform player;

private bool hasWon = false; // Prevent multiple scene loads

void Update()
{
    if (hasWon) return; // Stop checking after winning
    if (player == null)
    {
        Debug.LogError("Player Transform not assigned!");
        return;
    }

    // Calculate distance to the win point
    float distanceToWin = Vector3.Distance(player.position, winPoint);

    if (distanceToWin <= winDistance)
    {
        // Check if player has the key
        PlayerInventory inventory = player.GetComponent<PlayerInventory>();
        if (inventory != null)
        {
            if (inventory.hasKey)
            {
                WinGame();
            }
            else
            {
                Debug.Log("You need the key to complete Maze2!");
            }
        }
        else
        {
            Debug.LogError("PlayerInventory component missing on player!");
        }
    }
}

void WinGame()
{
    hasWon = true;
    Debug.Log("Player has the key! Maze2 complete!");
        SceneManager.LoadScene(2);
}
}