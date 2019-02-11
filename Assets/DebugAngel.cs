using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugAngel : MonoBehaviour
{
   

    // Update is called once per frame
    
        public void OnTriggerEnter(Collider other)
    { Debug.Log("angel activated"); }
    
}
