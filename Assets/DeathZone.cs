using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // zum szene laden
using UnityEngine.UI;               // für leben usw

public class DeathZone : MonoBehaviour
{
    public GameObject deathMenuUI;

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Waiting());
        deathMenuUI.SetActive(true);
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0f;
    }
}
