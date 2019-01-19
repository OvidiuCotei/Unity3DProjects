using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
// Class: RotateModels
// Desc: Contine toate metodele pentru functionalitatea
//       sistemului de rotire a meniului vizualizat in 3D.
//       Acesta se roteste la procesului de swipe pe ecranul
//       telefonului.
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
