using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private AudioSource AS;

    private void Start()
    {
        AS =  this.GetComponent<AudioSource>();
    }

    public void PlayClick()
    {
        AS.Play();
    }
}
