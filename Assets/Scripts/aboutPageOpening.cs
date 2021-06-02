using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aboutPageOpening : MonoBehaviour
{
    public GameObject aboutdialogpanel;
    public void openaboutpage()
    {
       // Debug.Log("a");
     aboutdialogpanel.SetActive(true);
    }
    public void closeaboutpage()
    {
        
        aboutdialogpanel.SetActive(false);
    }
}
