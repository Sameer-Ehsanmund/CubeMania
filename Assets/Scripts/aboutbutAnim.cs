using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aboutbutAnim : MonoBehaviour
{
    public RectTransform trans;
    
    public void OnMouseEnter()
    {

        trans.transform.localScale = new Vector3(1f, 2.5f, 1f);
        
      //  GetComponent<Animator>().enabled = true;
    }
    public void OnMouseExit()
    {

     //   GetComponent<Animator>().enabled = false;
        trans.transform.localScale = new Vector3(0.7f,1.5f,1f);
        
    }
}
