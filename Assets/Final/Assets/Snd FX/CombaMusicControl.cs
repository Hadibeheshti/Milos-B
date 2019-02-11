using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class CombaMusicControl : MonoBehaviour
{


    public AudioMixerSnapshot drums;
    public AudioMixerSnapshot gamemusic;
    //public AudioClip[] stings;
    //public AudioSource stingSource;
    public float bpm = 128;


    private float m_TransitionIn;
    private float m_TransitionOut;
    private float m_QuarterNote;

    // Use this for initialization
    void Start()
    {
        m_QuarterNote = 60 / bpm;
        m_TransitionIn = m_QuarterNote;
        m_TransitionOut = m_QuarterNote * 32;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drums"))
        {
            drums.TransitionTo(m_TransitionIn);
            //PlaySting();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Drums"))
        {
            drums.TransitionTo(m_TransitionOut);
        }
    }

    //void PlaySting()
    //{
    //    int randClip = Random.Range(0, stings.Length);
    //    stingSource.clip = stings[randClip];
    //    stingSource.Play();
    //}


}