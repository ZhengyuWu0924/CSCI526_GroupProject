using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // public string firstLevel;

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(2);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
        // Debug.Log("Quit!");
    }
}
