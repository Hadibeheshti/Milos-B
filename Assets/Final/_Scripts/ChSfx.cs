using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChSfx : MonoBehaviour {
	public AudioClip sndDie;
	public AudioClip sndJump;
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


