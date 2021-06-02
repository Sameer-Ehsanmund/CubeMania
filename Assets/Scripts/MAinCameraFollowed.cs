using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAinCameraFollowed : MonoBehaviour
{
  
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offsetMC; //vecctor3 stores three floats meaning X,Y and Z
    // Update is called once per frame
    void FixedUpdate()
    {
        FindObjectOfType<startTEXT>().start();
      //  Debug.Log("we hit something");
        //Debug.Log(player.position);//position of player..
        Vector3 desiredPosition = player.position + offsetMC;
        Vector3 smoothedPosition =Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition; //position of main camera goes to the centre of the player and moves with it..

        transform.LookAt(player);
            
        
    }
    
}
