using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject optionsButton;
    public GameObject quitButton;

    public void PlayGame()
    {
        playButton.SetActive(true);
        if (true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void Controls()
    {
        optionsButton.SetActive(true);
        if (true)
        {
            SceneManager.LoadScene("Controls");
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
