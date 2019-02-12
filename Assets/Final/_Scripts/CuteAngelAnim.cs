using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuteAngelAnim : MonoBehaviour
{

    public GameObject ModelToUp;

    public GameObject LifeAngelModel;
    public GameObject Stoned;
    public float speed =3f ;
    private bool movingUp = false;
   


    public Animator AngelAnimator;
    // Start is called before the first frame update
    void Start()
    {
        AngelAnimator = GetComponentInChildren<Animator>();
       // myCollider = GetComponent<Collider>();
        LifeAngelModel.SetActive(false);
        Stoned.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (movingUp == true)
        {
            ModelToUp.transform.position += new Vector3(0.0f, 1.0f * Time.deltaTime, 0.0f);
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            AngelAnimator.SetBool("Live", true);
            Stoned.SetActive(false);
            LifeAngelModel.SetActive(true);
            GetComponent<Collider>().enabled = false;
            movingUp = true;
           // Destroy(ModelToUp, 2f);
            

        }


    }

    //private void Live()
    //{

    //    AngelAnimator.SetBool("Live", true);


    //}



    

}
