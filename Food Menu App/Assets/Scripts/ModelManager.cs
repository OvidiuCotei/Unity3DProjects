using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
// Class: ModelManager
// Desc: Contine toate metodele pentru functionalitatea
//       sistemului de activare si dezactivare a modelelor
//       3D atunci cand acestea sunt selectate din meniu.
// _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
public class ModelManager : MonoBehaviour {

    public GameObject[] models;

    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    // Method: Start
    // Desc: Folosita pentru initializarea referintelor atunci
    //       cand aplicatia porneste.
    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    private void Start()
    {
        DisableAll();
    }

    private void DisableAll()
    {
        foreach(var item in models)
        {
            item.SetActive(false);
        }
    }

    private void SetModel(int index)
    {
        // Dezacivare celelalte modele inaite de activarea unui model
        DisableAll();
        models[index].SetActive(true);
    }
}