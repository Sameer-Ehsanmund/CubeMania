using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliding : MonoBehaviour
{
    public playerMovement movement;
   
   
        
    void OnCollisionEnter (Collision info) //built in methid that Unity understands..
    {
        if (info.collider.tag == "blocks") //name of colliding object will show..
        {
           // Debug.Log("we hit a block.");
            movement.enabled = false;
            FindObjectOfType<GameManager1>().EndGame();
        }
       
        //Debug.Log(info.collider.name);//name of the colliding object will be displayed in the console..
    }
    
}
