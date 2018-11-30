using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

    public AudioClip MainTheme;
    public AudioClip HomeBG;
	




	public AudioSource myAudiosrc;


	// Use this for initialization
	void Start () {
		
		DontDestroyOnLoad(transform.gameObject);




        myAudiosrc.clip = HomeBG;

        myAudiosrc.Play ();
	}
	


}
