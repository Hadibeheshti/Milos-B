using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    bool connected;
    // Start is called before the first frame update
    void Start()
    {

        Connection(true);
        BeatGiver.hurt += Aua;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Connection(bool attached)
    {
        if (attached == connected) return;

        if(attached)
            BeatGiver.jump += Hop;
        else
            BeatGiver.jump -= Hop;
        connected = attached;
    }

    void Aua(int schmerz)
    {
        if (schmerz > 20)
            Debug.Log("AU");
        else
            Debug.Log("Uff");
    }

    void Hop()
    {
        transform.position += Random.insideUnitSphere;
    }

    void OnDestroy()
    {
        Connection(false);
        BeatGiver.hurt -= Aua;
    }
}
