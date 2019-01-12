using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPlayer : MonoBehaviour
{
    public float movementSpeed = 4f;
    public float acceleration = 2.5f;


    private float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += acceleration * Time.deltaTime;
        if (speed > movementSpeed)
        {
            speed = movementSpeed;
        }
        //moveHorizontally
        GetComponent<Rigidbody>().velocity = new Vector3(
            
            GetComponent<Rigidbody>().velocity.x, 
            
            GetComponent<Rigidbody>().velocity.y,
            
            speed
            
            );





    }
}
