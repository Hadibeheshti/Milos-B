﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{   
    //Publics
    [Header("Accelerations")]
    public float acceleration = 2.5f;
    public float deacceleration = 5.0f;

    [Header("Movement Fields")]
    [Range (4f, 6f)]
    public float movementSpeed = 4.0f;
    [Range(0f, 12f)]
    public float movementSpeedRight = 8.0f;
    [Range(0f, 12f)]
    public float movementSpeedLeft = 2.0f;

    [Header("Jumping Fields")]
    [Range(0f, 12f)]
    public float normalJumpingSpeed = 6.0f;
    [Range(0f, 12f)]
    public float longJumpingSpeed = 10.0f;
    [Range(0f, 12f)]
    public float jumpDuraition = 0.75f;
    [Range(0f, 12f)]
    public float verticalWallJumpingSpeed = 5.0f;
    [Range(0f, 12f)] 
    public float horizontalWallJumpingSpeed = 3.5f;
    //privates
    private bool dead = false;
    private float jumpingTimer = 0.0f;

    public Action onCollectCoin;

    private float speed = 0.0f;
    private float jumpingSpeed = 0f;
    private bool canJump = false;
    private bool jumping = false;
    private bool canWallJump = false;
    private bool wallJumpLeft = false;
    private bool onSpeedAreaLeft = false;
    private bool onSpeedAreaRight = false;
    private bool onLongJumpBlock = false;
    public bool Dead
    {
        get
        {
            return dead;

        }

    }
   





    private void Start()
    {
        jumpingSpeed = normalJumpingSpeed;
        
    }

    void Update()
    {
        if (dead)
        {
            return;
        }
        //Accelerate the Player.
        speed += acceleration * Time.deltaTime;

        float targetMovementSpeed = movementSpeed;
        if (onSpeedAreaLeft)
        {
            targetMovementSpeed = movementSpeedLeft;
        }

        else if (onSpeedAreaRight)
        {
            targetMovementSpeed = movementSpeedRight;
        }




        if (speed > targetMovementSpeed)
        {
            speed -= deacceleration * Time.deltaTime;
           
        }
        //Move horizontally.
            GetComponent<Rigidbody>().velocity = new Vector3(
            GetComponent<Rigidbody>().velocity.x,
            GetComponent<Rigidbody>().velocity.y, 
            speed);
        //Check for Inputs.

        bool pressingJumpButton = Input.GetMouseButton(0) || Input.GetKey("space");
        if (pressingJumpButton)
        {
            if (canJump)
            {
                Jump();
            }
        }

        //Make the Player Jump.
        if (jumping) { 
        {
            jumpingTimer += Time.deltaTime;

            if (pressingJumpButton && jumpingTimer < jumpDuraition)
            {
                    if (onLongJumpBlock == true)
                    {
                        jumpingSpeed = longJumpingSpeed;
                    }
                GetComponent<Rigidbody>().velocity = new Vector3(
                GetComponent<Rigidbody>().velocity.x,
                jumpingSpeed,
                GetComponent<Rigidbody>().velocity.z
                );
            }
        }
    }
        //Make the Player Wall Jump.
        if (canWallJump)
        {
            speed = 0;
            if (pressingJumpButton)
            {
                canWallJump = false;
            
            speed = wallJumpLeft ? -horizontalWallJumpingSpeed : horizontalWallJumpingSpeed;

            GetComponent<Rigidbody>().velocity = new Vector3(
                GetComponent<Rigidbody>().velocity.x,
                verticalWallJumpingSpeed,
                GetComponent<Rigidbody>().velocity.z


                );
          }
    
     }

    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        // Speed up or down.
        if (otherCollider.GetComponent<SpeedArea>() != null)
        {
            SpeedArea speedArea = otherCollider.GetComponent<SpeedArea>();
            if (speedArea.direction == Direction.Left)
            {
                onSpeedAreaLeft = true;
            }
            else if (speedArea.direction == Direction.Right)
            {
                onSpeedAreaRight = true;
            }

        }
        // Perform long jump.
        if (otherCollider.GetComponent<LongJumpBlocks>() != null)

        {
            onLongJumpBlock = true;

        }

        //kill the player when they the Enemy.

        if (otherCollider.GetComponent<Enemy>() != null)
        {
            Enemy enemy = otherCollider.GetComponent<Enemy>();
            if (enemy.Dead == false)
            {
                Kill();
            }
           

        }
        
    }


    void OnTriggerStay(Collider otherCollider)

    {
        if (otherCollider.tag == "JumpingArea")
        {
            canJump = true;
            jumping = false;
            jumpingSpeed = normalJumpingSpeed;
            jumpingTimer = 0f;


        }
        else if (otherCollider.tag == "WallJumpingArea")
        {
            canWallJump = true;
            wallJumpLeft = transform.position.z < otherCollider.transform.position.z;
        }

       
    }

    private void OnTriggerExit(Collider otherCollider)
    {
        if (otherCollider.tag == "WallJumpingArea")
        {
            canWallJump = false;
        }
        if (otherCollider.GetComponent<SpeedArea> () !=null)
        {
                    
        SpeedArea speedArea = otherCollider.GetComponent<SpeedArea>();

        if (speedArea.direction == Direction.Left)
        {
            onSpeedAreaLeft = false;
        }
        else if (speedArea.direction == Direction.Right)
        {
            onSpeedAreaRight = false;
        }


    }

        if (otherCollider.GetComponent<LongJumpBlocks>() != null)

        {
            onLongJumpBlock = false;

        }

    }


    void Kill ()
    {
        dead = true;
       // GetComponent<Collider>().enabled = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().AddForce(new Vector3(0f, 500f, -50f));


    }

    public void Jump(bool forced = false )
    {

        jumping = true;

        if (forced )
        {
            GetComponent<Rigidbody>().velocity = new Vector3(
              GetComponent<Rigidbody>().velocity.x,
              jumpingSpeed,
              GetComponent<Rigidbody>().velocity.z
              );
        }
        


    }

    public void OnDestroyBrick()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(
            GetComponent<Rigidbody>().velocity.x,
            0,
            GetComponent<Rigidbody>().velocity.z
        );
        canJump = false;
        jumping = false;
    }




}








































/*

{   

   /// <summary>
   /// Lauf Geschwindigkeigt der Figur
   /// </summary>
   public float speed = 0.1f;
   [SerializeField] float myRaycastLength = 1;
   /// <summary>
   /// Das grafische Model, u.a. für die Drehung in Laufrichtung.
   /// </summary>
   public GameObject model;
   /// <summary>
   /// Der Winkel zu dem sich die Figur um die eigene Achse (=Y) drehen soll.
   /// </summary>
   private float towardsY = 0f;

   /// <summary>
   /// Drehung Geschwindigkeigt
   /// </summary>
   public float turnSpeed = 10;
   // Die Kraft, mit der nach oben gesprungen wird.
   public float jumpPush = 10f;
   // Verstärkung der Gravity um die Figur schneller runter fällt.
   public float extraGravity = -20f;
   public float fallMultiplier = 2.5f;
   // Ist die Figur gerade auf dem Boden ?Wenn false , fält oder sprint sie ?
   private bool onGround = false;
   public Rigidbody rigid;
   //die Figure kann sich nach dem Tot bewegen.    
   public GameObject PlayerGameObjcet;
   /// <summary>
   /// Zeiger auf die Animation Komponente der Spiel Figur
   /// </summary>
   private Animator anim;

   //Run Motion 
   bool Run = true;


   //Code Incativer

   bool die = false;

   public bool enter = true;

   private Collider playerColid;

   // Start is called before the first frame update
   void Start()
   {
       float h = Input.GetAxis("Horizontal");
       rigid = GetComponent<Rigidbody>();
       anim = GetComponentInChildren<Animator>();
       playerColid = GetComponent<Collider>();


   }

   // Update is called once per frame
   void Update()
   {


       float h = Input.GetAxis("Horizontal");
       float v = Input.GetAxis("Vertical");




       Movements();
       Rotation();
       Jumping();
       anim.SetFloat("forward", Mathf.Abs(h));



   }  


   void Movements()
   {   //Forward and Backward

        if(die == false )
       {

           float h = Input.GetAxis("Horizontal");
           transform.position += h * speed * transform.forward;

       }


       }

   void Rotation()
   {
       float h = Input.GetAxis("Horizontal");


       if (h > 0f && die ==false) //nach rechts drehen.
       {
           towardsY = 0f;
           model.transform.rotation = Quaternion.Lerp(model.transform.rotation, Quaternion.Euler(0f, towardsY, 0f), Time.deltaTime * turnSpeed);
       }
       else if (h < 0f && die ==false) //nach links drehen.
       {

           towardsY = -180f;
           model.transform.rotation = Quaternion.Lerp(model.transform.rotation, Quaternion.Euler(0f, towardsY, 0f), Time.deltaTime * turnSpeed);

       }

   }

       void Jumping()
    {
        if (die ==false){
           RaycastHit hitInfo;
           Debug.DrawRay(transform.position + (Vector3.up * 0.05f), Vector3.down, Color.cyan, myRaycastLength);
           onGround = Physics.Raycast(transform.position + (Vector3.up * 0.05f), Vector3.down, out hitInfo, myRaycastLength);
       anim.SetBool("grounded", onGround);
}
           if (Input.GetAxis("Jump") > 0f && onGround && die ==false)
           {
                Vector3 power = rigid.velocity;
                power.y = jumpPush;
                rigid.velocity = power;
                rigid.AddForce(new Vector3(0f, extraGravity, 0f));
               //GetComponent<Rigidbody>().velocity = Vector3.up * jumpPush; 
               // rigid.AddForce((Vector3.up * jumpPush), ForceMode.Impulse);
               // rigid.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;


           }

       }

   //Die
       private void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.tag == "Monster")
       {
           anim.SetBool("die", true);
           //playerColid.isTrigger = true;

           die = true;
           Coin.instance.GameOver();




       }
   }

}

   */


/*

  void   MoveAndRotate() {

      horizontal = Input.GetAxis ("Horizontal");
      vertical = Input.GetAxis("Vertical");
  if (vertical != 0) {

      transform.Translate(Vector3.forward * speed);

  }

  if(die ==false && Input.GetKey(KeyCode.RightArrow))
  {

      anim.SetBool("TopDown", true);

  }

  this.transform.Rotate(Vector3.up * horizontal * turnSpeed, Space.World);


}

*/
