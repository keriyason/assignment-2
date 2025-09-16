using UnityEngine;
using UnityEngine.SceneManagement; // Important: Add this namespace

public class SceneChanger : MonoBehaviour
{
    // Function to load a scene by its name
    public void LoadSceneByName(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }

    // Function to load a scene by its build index
    public void LoadSceneByIndex (int sceneIndex)
    {
        SceneManager.LoadScene(1);
    }
}