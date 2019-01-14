using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public float movementAmplitude = 4f;
    private Vector3 initialPosition;
    private bool movingLeft = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (

            transform.position.x,
            transform.position.y,
            transform.position.z + speed * Time.deltaTime * (movingLeft ? -1 : 1)
            );

        if (movingLeft ==true && transform.position.z < initialPosition.z - movementAmplitude /2)
        {
            movingLeft = false;
        } else  if (movingLeft == false && transform.position.z > initialPosition.z + movementAmplitude / 2)
            {
                movingLeft = true;
            }


         

    }
  


    }

