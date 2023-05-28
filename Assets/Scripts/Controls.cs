using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject backTomenuButton;

    public void BackToMenu()
    {
        backTomenuButton.SetActive(true);
        if (true)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
