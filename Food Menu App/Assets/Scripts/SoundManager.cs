using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
// Class: SoundManager
// Desc: Contine toate metodele pentru functionalitatea
//       sistemului de sunet, astfel incat atunci cand 
//       utiliatorul da click pe un buton acesta va emite un
//       sunet.
// _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
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
