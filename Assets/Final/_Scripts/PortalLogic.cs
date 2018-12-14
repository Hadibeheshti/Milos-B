using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalLogic : MonoBehaviour
{
    public Animator RockRoller;
    

    // Start is called before the first frame update
    void Start()
    {
        RockRoller = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            RockRoller.SetBool("RollerStoneRolling", true);
            //playerColid.isTrigger = true;

           
        }


}
}
