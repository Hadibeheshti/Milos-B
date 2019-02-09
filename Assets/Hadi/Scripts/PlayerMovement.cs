using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    // Model für Drehung in Laufrichtung
     public GameObject model;

    // LaufGeschwindigkeit

    public float movementSpeed = 5f;
    // Für Springen *1
    public float jumpPower = 350f;
    // Für DoubleSprung *1
    public float secondJumpPower = 400f;
    // Position von Object das für Boden checking ich benutze
    public Transform groundCheeckPosition;
    // Boden checker *1
    public float radius = 0.3f;
    // Boden Layer *1
    public LayerMask layerGround;
    // RigidBody
    private Rigidbody myBody;
    // Ob es auf dem Boden ist oder nicht *1
    private bool isGrounded;
    //*1
    //private bool playerJumped = false;
    //*1
    private bool canDoubleJump =false;
    //Der Winkel zu dem sich Figur um die eigene Achse (=Y) drehen soll.
    private float towardsY = 0f;
    // Player Rotation Speed
    public float _RotateSpeed = 10;
    // Die Kraft, mit der nach oben gesprungen wird.
    public float jumpPush = 1f;
    // Verstärkung der Gravity um die Figur schneller runter fällt.
    public float extraGravity = 20f;
    // Ist die Figur gerade auf dem Boden ?Wenn false , fält oder sprint sie ?
    private bool onGround = false;

    
    private void Update()
    {   //Diese drei Methode können in FixedUpdate auch sein später testen !
       // PlayerMove();
        PlayerGrounded();
       // PlayerJump();
        PlayerRotation();
       Jumping();
        

    }

    // Start is called before the first frame update
    void Awake ()
    {
      myBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {   
       
      
        
            
    }
    /*
    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            myBody.velocity = new Vector3(movementSpeed, myBody.velocity.y, 0f) ;
        }

         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            myBody.velocity = new Vector3(-movementSpeed, myBody.velocity.y, 0f);
        }
          
       
          }
          */
    void PlayerGrounded() {

        isGrounded = Physics.OverlapSphere(groundCheeckPosition.position, radius, layerGround).Length > 0;


    }
    
    void PlayerJump() {

    if (Input.GetKeyDown (KeyCode.Space) && isGrounded)
        {
            myBody.AddForce (new Vector3(0,jumpPower,0));
           // playerJumped = true;
            canDoubleJump = true;
           

        }
        else if (Input.GetKeyUp(KeyCode.Space) && !isGrounded && canDoubleJump)
        {
            canDoubleJump = false;
            myBody.AddForce(new Vector3(0, secondJumpPower, 0));
            

        }
      }

    
    //Drehen
    void PlayerRotation()
    {

        float h = Input.GetAxis("Horizontal");

        if (h > 0f) //nach rechts gehen
       
            towardsY = 0f;

        else if (h < 0f) //nach links gehen

            towardsY = -180f;
        
            model.transform.rotation = Quaternion.Lerp(model.transform.rotation, Quaternion.Euler
            (0f, towardsY, 0f), Time.deltaTime*_RotateSpeed);

    }

    

        void Jumping()
        {
            RaycastHit hitInfo;
            onGround = Physics.Raycast(transform.position + (Vector3.up * 0.1f), Vector3.down, out hitInfo, 1f);
            if (Input.GetAxis("Jump") > 0f && onGround )
            {
                Vector3 power = myBody.velocity;
                power.y = jumpPush;
                myBody.velocity = power;
                myBody.AddForce(new Vector3(0f, extraGravity, 0f));


            }


    }
    

}

