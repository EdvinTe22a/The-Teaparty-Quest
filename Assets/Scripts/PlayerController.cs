using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    public GameObject öppning;
    public GameObject fourButton;
    public GameObject dialog;
    public GameObject mattePussel;
    public GameObject pusselZon;
    public GameObject målLinje;
    public GameObject backTomenuButton;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
        backTomenuButton.SetActive(false);
        målLinje.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialog.SetActive(false);
            Time.timeScale = 1;
        }
        horizontal = Input.GetAxis("Horizontal");
        vertical= Input.GetAxis("Vertical");

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Castle"))
        {
            målLinje.SetActive(true);
            backTomenuButton.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Respawn()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void VäggÖppen()
    {
        Destroy(öppning);
        mattePussel.SetActive(false);
        pusselZon.SetActive(false);
        Time.timeScale = 1;
    }
    public void BackToMenu()
    {
        backTomenuButton.SetActive(true);
        if (true)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
       body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
 
}
