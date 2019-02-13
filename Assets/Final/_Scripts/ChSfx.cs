using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChSfx : MonoBehaviour {
	public AudioClip sndDie;
	public AudioClip sndJump;
    public AudioClip RollerStone;
    public AudioClip MiloRunClip;
    public AudioClip FlyingStone;
    public AudioClip CuteAngel;
    public AudioClip HammerS;
    public AudioClip NeedleRaus;
    public AudioClip NeedleRein;
    public AudioClip RopeS;
    public AudioClip AngryFlowerS;



    //AudioSource
    AudioSource audioSource;

	// Use this for initialization
 void Start () {

   audioSource= GetComponent<AudioSource>();
	
	}



	// Update is called once per frame
	void Update () {

				JumpSound () ;
				
		}

    void AngryFlowerF()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(AngryFlowerS);
        

    }

    void NeedleRausF()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(NeedleRaus);

    }

    void RopeF()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(RopeS);

    }

    void NeedleReinF()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(NeedleRein);

    }

    void MiloRunFunc()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(MiloRunClip);

    }

    void HammerF()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(HammerS);

    }


    void FlySton()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(FlyingStone);

    }

    void CuteF()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(CuteAngel);

    }



    void RollerStoneSndfx ()
    {

        gameObject.GetComponent<AudioSource>().PlayOneShot(RollerStone);

    }

//Die sound Script 

void JumpSound () {

		if (Input.GetKeyDown(KeyCode.Space)) {
      
        gameObject.GetComponent<AudioSource>().PlayOneShot (sndJump);
		}

}



void DieSound() {

gameObject.GetComponent<AudioSource>().PlayOneShot (sndDie);
 
 sndDie = null;
 
 sndJump = null;
	

}

}


