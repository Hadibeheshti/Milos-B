using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatGiver : MonoBehaviour
{
   public static System.Action jump;
    public static System.Action<int> hurt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (jump != null) jump();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (jump != null) hurt(Random.Range(0,100));
        }
    }
}
