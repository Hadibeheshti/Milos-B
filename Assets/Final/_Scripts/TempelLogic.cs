using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempelLogic : MonoBehaviour
{
    public GameObject myGameObject;

    // Start is called before the first frame update
    void Start()
    {
        myGameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.tag =="Player")
        {
            myGameObject.SetActive(true);

        }
    }
}
