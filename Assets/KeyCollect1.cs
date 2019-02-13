using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyCollect1 : MonoBehaviour
{
    public GameObject[] Keys = new GameObject[4];
    public GameObject TotemAir;

    private void Start()
    {
        GameObject temp = GameObject.Find("AnchorTopRight");
        for (int i = 0; i < Keys.Length; i++)
        {
            Keys[i] = temp.transform.Find("Schlüsselfragment" + (i + 1)).gameObject;
            Keys[i].SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Update()
    {



    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (transform.tag == "Schlüsselfragment1")
            {
                TotemAir.SetActive(true);
                Keys[0].SetActive(true);
                Destroy(this.gameObject);

            }

            //Destroy(gameObject);

        }
    }
}
