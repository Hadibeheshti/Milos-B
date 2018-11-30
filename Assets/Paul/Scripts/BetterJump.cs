using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{/// <summary>
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

 void FixedUpdate() {
     if (Input.GetButtonDown("Jump"))
     {
        GetComponent<Rigidbody>().velocity = Vector3.up * jumpPush; 
        rigid.AddForce((Vector3.up * jumpPush), ForceMode.Impulse);
        rigid.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
     }
    
}    
    
}
