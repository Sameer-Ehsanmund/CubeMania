using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class chngngfontstyles : MonoBehaviour
{
    public Text abouttxt;

    public void OnMouseEnter()
    {

        abouttxt.fontStyle = FontStyle.Bold;
    }
    public void OnMouseExit()
    {

        abouttxt.fontStyle = FontStyle.Normal;
    }
    public void ProceedToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
