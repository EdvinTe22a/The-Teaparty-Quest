using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusselzonscript : MonoBehaviour
{
    //public PlayerController playerController;
    public GameObject mattePussel;

    void Start()
    {
        mattePussel.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            mattePussel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
 