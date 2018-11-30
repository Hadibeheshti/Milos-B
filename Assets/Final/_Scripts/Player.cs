using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// Lauf Geschwindigkeigt der Figur
    /// </summary>
    public float speed = 0.1f;
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

    // Start is called before the first frame update
    void Start()
    {
        float h = Input.GetAxis("Horizontal");
        rigid = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();


        
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
            onGround = Physics.Raycast(transform.position + (Vector3.up * 0.05f), Vector3.down, out hitInfo, 0.05f);
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
            
            die = true;
            Coin.instance.GameOver();


            
        }
    }
    
}



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
