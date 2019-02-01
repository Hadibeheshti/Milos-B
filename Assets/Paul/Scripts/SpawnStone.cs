using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    public static List<SpawnStone> stones = new List<SpawnStone>();
   public GameObject rollerStone;
    // IEnumerator Start() {
        
    //     yield return new WaitForSeconds(2f);
    //     Debug.Log("waited for 2 sec");
    // }
    void Start()
    {
        stones.Add(this);
    }

   public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(rollerStone, transform.position, Quaternion.identity);
        Debug.Log("waited for 2 sec");
    }

    public static void TriggerAll()
    {
        foreach(SpawnStone stone in stones)
        {
            stone.StartCoroutine(stone.Spawn());
        }
    }

    public static SpawnStone GetNearest(Vector3 position)
    {
        float distance = 999999999999999999999999999999999.0f;
        float temp;
        SpawnStone result = null;
        foreach(SpawnStone stone in stones)
        {
            temp = Vector3.Distance(stone.transform.position, position);
            if (temp <distance)
            {
                distance = temp;
                result = stone;
            }
        }
        return result;
    }

   void OnDestroy()
   {
       stones.Remove(this);
   }
}
