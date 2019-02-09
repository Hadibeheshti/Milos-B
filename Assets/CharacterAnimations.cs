using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //    anim.SetBool("grounded", true);

          //  anim.SetFloat("forward", 1f);
           anim.SetBool("TopDown", true);

        }

        /*else if 
            
            (Input.GetKey(KeyCode.Space))
            
            {

            anim.SetBool("TopDown", false);


        }

        else
        {
            anim.SetBool("grounded", true);
            anim.SetFloat("forward", 0.0f);
            anim.SetBool("TopDown", false);
        }

    */
      
    }
}
