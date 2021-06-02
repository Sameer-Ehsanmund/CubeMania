using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageanimationinMODES : MonoBehaviour
{
    public Text abouttxt;
   // public float width;
   // public float width2;
   
   
    public void OnMouseEnter()
    {

        abouttxt.fontStyle = FontStyle.Bold;
    //in order to change the width of image
      //  GameObject theBar = GameObject.Find("EndMimg");
      //  var theBarRectTransform = theBar.transform as RectTransform;
     //   theBarRectTransform.sizeDelta = new Vector2(width, theBarRectTransform.sizeDelta.y);

    }
    public void OnMouseExit()
    {

        abouttxt.fontStyle = FontStyle.Normal;

      //  GameObject theBar = GameObject.Find("EndMimg");
      //  var theBarRectTransform = theBar.transform as RectTransform;
       // theBarRectTransform.sizeDelta = new Vector2(width2, theBarRectTransform.sizeDelta.y);

    }

    public void comingSoonAnim()
    {

       
    }
}
