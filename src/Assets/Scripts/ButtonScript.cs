using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadSinglePlayer()
    {
        SceneManager.LoadScene("Singleplayer");
    }

    public void loadGameSettings()
    {
        SceneManager.LoadScene("GameSettings");
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void quitGame()
    {
        Application.Quit();
    }

}
