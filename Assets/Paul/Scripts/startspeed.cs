using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startspeed : MonoBehaviour
{
    public int speed = 16;
    public Rigidbody rb;  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, speed, ForceMode.Impulse);
    }

    
}
