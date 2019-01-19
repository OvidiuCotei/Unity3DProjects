using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour {

    public GameObject[] models;

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