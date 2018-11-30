using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    private GameObject Key1;
    private GameObject Key2;
    private GameObject Key3;
    private GameObject Key4;

    // Start is called before the first frame update
    void Update ()
    {
        Key1 = GameObject.FindGameObjectWithTag("Schlüsselfragment1");
        Key2 = GameObject.FindGameObjectWithTag("Schlüsselfragment2");
        Key3 = GameObject.FindGameObjectWithTag("Schlüsselfragment3");
        Key4 = GameObject.FindGameObjectWithTag("Schlüsselfragment4");


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) ;
        Destroy(Key1.gameObject);
        Destroy(this.gameObject);

    }
}
