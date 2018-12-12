using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentMechanics : MonoBehaviour
{
    public GameObject myPlayer;




    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == myPlayer)
        {
            myPlayer.transform.parent = transform;
        }



    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject == myPlayer)
        {
            myPlayer.transform.parent = null;
        }
    }



}