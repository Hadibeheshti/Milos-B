using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingStoneScript : MonoBehaviour
{
    public int speed = 16;
    public Rigidbody rb;  
    public GameObject newRollingStone;
    public GameObject RollingStone;
    public float resetDelay = 3;
    public UnityEngine.Vector3 spawnpoint;

    //public GameObject RollingStone;  
    

    void Start()
    {
        spawnpoint = this.transform.position;
        
        //GameObject newRollingStone = (GameObject)GameObject.Instantiate(RollingStone, transform.position, Quaternion.identity);
    }
    // void Spawn()
    // {
    //     spawnpoint  = new Vector3(-14, 1, 0);
    // }
   
    void OnTriggerExit(Collider other){
        SpawnStone mop = SpawnStone.GetNearest(spawnpoint);
        if (mop != null)
                mop.StartCoroutine(mop.Spawn());
        //Invoke("SetupStone", resetDelay);
        Destroy(this.gameObject);
        Debug.Log("invoked");
    }
     void SetupStone()
    {
        newRollingStone = Instantiate(RollingStone, spawnpoint, Quaternion.identity);
    }

    // Update is called once per frame
   // void FixedUpdate()
     //if (Input.GetKeyDown("k")) //testing purpose
        //rb.AddForce(speed, 0, 0, ForceMode.Impulse);
    
}
