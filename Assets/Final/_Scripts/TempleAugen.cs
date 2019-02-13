using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleAugen : MonoBehaviour
{
    public Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {

        myAnim = GetComponent<Animator>();
        myAnim.SetBool("Augen", false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.tag =="Player")
        {
            myAnim.SetBool("Augen",true);

        }
    }
}
