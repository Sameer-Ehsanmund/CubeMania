using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausingtheGameScript : MonoBehaviour
{
    public GameObject pausingpanel;
   
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pausingpanel.SetActive(true);
            }
            else
            {
                pausingpanel.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
    public void resumeGame()
    {

        pausingpanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void leaveGame()
    {
        
        SceneManager.LoadScene("opening tester 1");
        Time.timeScale = 1; // if it doesnot happen, the timescale remains zero
       // FindObjectOfType<GameManager1>().EndGame();
       // SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
