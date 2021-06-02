using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityStandardAssets.CrossPlatformInput;


public class playerMovement : MonoBehaviour
{
    public Rigidbody rb; //public component object..
   // public Transform trans;
    public float ForwardSpeed; //speeed for the player to move forwad
   // public float SideMOvingSpeed;

    //public GameObject player;
   // Touch initTouch;
   // bool swiped = false;

   // public float speedModifier;

   // private Rigidbody2D rb2;
    private float directionX;
    private float SideMOvingSpeed = 20f;


    // Start is called before the first frame update  
    void Start()  //fixed added cause we are messing with Physics..
    {

        FindObjectOfType<startTEXT>().start();

        rb = GetComponent<Rigidbody>();
       // speedModifier = 0.05f;
       // rb.useGravity = true;  //property of gravity can be changed to true or false..
     //   rb.AddForce(0, 0, 0 * Time.deltaTime);//frames of a computer depending upon time..
    }

    // Update is called once per frame

    void FixedUpdate()
    {

        // Another Andriod Input Method
        directionX = CrossPlatformInputManager.GetAxis("Horizontal") * SideMOvingSpeed;
        rb.velocity = new Vector3(directionX, 0f, ForwardSpeed * Time.deltaTime);


        // Input on Windows
        // rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime);
        //  if(Input.GetKey("d")){    //getting keys to moved around the player..
        //      rb.AddForce(SideMOvingSpeed * Time.deltaTime,0,0,ForceMode.Impulse);
        // }
        //  if (Input.GetKey("a"))
        // {
        //     rb.AddForce(-(SideMOvingSpeed * Time.deltaTime), 0, 0, ForceMode.Impulse);
        // }


        //Input on Andriod
        //  if (Input.touchCount > 0)
        // {
        //  initTouch = Input.GetTouch(0); // get first touch since touch count is greater than zero

        //  if (initTouch.phase == TouchPhase.Moved)
        //  {
        // get the touch position from the screen touch to world point
        //  Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
        // lerp and set the position of the current object to that of the touch, but smoothly over time.
        // transform.position = Vector3.Lerp(transform.position, touchedPos, SideMOvingSpeed*Time.deltaTime);


        //  transform.position = new Vector3(
        //     transform.position.x + initTouch.deltaPosition.x * speedModifier,
        //     transform.position.y,
        //     transform.position.z
        //    );

        //  }
        //  }


        if (rb.position.y <-1f)
          {

             FindObjectOfType<GameManager1>().EndGame();
          }


        // if (Input.GetKey(KeyCode.Escape)) //using Esc button
        //  {

        //     Debug.Log("pressed");
        // }


        //  if (Input.GetKey("w"))
        // {
        //     rb.AddForce(0, 40, 10);
        //}





        

    }
}
