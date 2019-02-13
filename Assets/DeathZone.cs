using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject deathMenuUI;
    private float restartTimer = 1f;
    //public Player player;
    //public static GameController instance = null;

    // Start is called before the first frame update
    //void Start()
    //{
    //    ded = GetComponent<DeathMenu>();

    //}

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        restartTimer -= Time.deltaTime;
        if (restartTimer <= 0f)
        {
            Time.timeScale = 0f;

        }

        deathMenuUI.SetActive(true);
    }
}
