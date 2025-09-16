using UnityEngine;
using UnityEngine.SceneManagement; // Important: Add this namespace

public class ReturntoStarting : MonoBehaviour
{
    // Function to load a scene by its name
    public void LoadSceneByName(string StartingScreen)
    {
        SceneManager.LoadScene(StartingScreen);
    }

    // Function to load a scene by its build index
    public void LoadSceneByIndex (int sceneIndex)
    {
        SceneManager.LoadScene(3);
    }
}