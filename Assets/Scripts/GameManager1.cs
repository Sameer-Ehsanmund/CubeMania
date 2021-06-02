using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    bool gameHasEnded = false;
    public float RestartDelay = 2f;
    public GameObject completedL;
    public void LevelCompletion()
    {
        completedL.SetActive(true);
        
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game ended");
            Invoke("RestartingGame", RestartDelay);

        }
    }
    void RestartingGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
