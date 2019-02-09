using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour


{
    
    
    //private bool AngelDead = true;



    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
       
     
    
    }


   



    

    public void Vanish()
    {

        StartCoroutine(VanishRoutine());


    }
    
    private IEnumerator VanishRoutine()
    {
        yield return new WaitForSeconds(0.2f);

       //Destroy(DeadAngelModel);



    }


}

