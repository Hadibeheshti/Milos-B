using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
   public GameObject RollingStone;
    // IEnumerator Start() {
        
    //     yield return new WaitForSeconds(2f);
    //     Debug.Log("waited for 2 sec");
    // }
    IEnumerator Spawn()
    {
        Instantiate(RollingStone, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        Debug.Log("waited for 2 sec");
    }

   
}
