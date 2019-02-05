﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_BackUp : MonoBehaviour
{
    public GameObject model;
    public float rotatingSpeed = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        model.transform.RotateAround(model.transform.position, Vector3.up, rotatingSpeed * Time.deltaTime);  


    }


    public void Vanish()
    {

        StartCoroutine (VanishRoutine());


    }

    private IEnumerator VanishRoutine ()
    {
        yield return new WaitForSeconds (0.3f);

        Destroy(this.gameObject);



    }

}