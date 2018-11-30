using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovements : MonoBehaviour
{
    public float MoveSpeed = 2;
    public float RotateSpeed = 2;
    public bool xRotate;
    public bool yRotate;
    public bool zRotate;
    public bool xTranslate;
    public bool yTranslate;
    public bool zTranslate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        xTransform();
        yTransform();



    }

    void xTransform()
    {
        if (xTranslate==true)
        {
            transform.Translate(MoveSpeed, 0, 0);
        }
        

    }

    void yTransform()
    {
        if (yTranslate == true)
        {
            transform.Translate(0, MoveSpeed, 0);
        }


    }
}
