using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class campaignImageTriggerer : MonoBehaviour
{

    public Transform trans;
    
    public GameObject imageposition;
    public GameObject imageposition2;
    public GameObject imageposition3;
    public Text levelBut;
    public void triggerImageWhenPointerEnters()
    {

        trans.transform.localScale = new Vector3(3.120274f, 1.834207f, 1f); 
        //imageposition.transform.position = new Vector3(1f,189f,0f);
        imageposition.GetComponent<RectTransform>().anchoredPosition=new Vector3(-145,189,0);
        imageposition2.GetComponent<RectTransform>().anchoredPosition = new Vector3(141, 195.9f, 0f);
        imageposition3.GetComponent<RectTransform>().anchoredPosition = new Vector3(-145, 22f, 0f);
        levelBut.fontStyle = FontStyle.Bold;
       // Debug.Log("pressed");
    }
    public void triggerImageWhenPointerLeaves()
    {

        trans.transform.localScale = new Vector3(2.713281f, 1.577812f, 1f);
        imageposition.GetComponent<RectTransform>().anchoredPosition = new Vector3(-145, 196, 0);
        imageposition2.GetComponent<RectTransform>().anchoredPosition = new Vector3(130, 195.9f, 0f);
        imageposition3.GetComponent<RectTransform>().anchoredPosition = new Vector3(-145, 35f, 0f);
        levelBut.fontStyle = FontStyle.Normal;
    }
}
