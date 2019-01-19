using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject modelsManager;
    public GameObject soundManager;
    public GameObject informationIcon;
    public GameObject informationPanel;
    public Sprite[] selectedSprites;
    public Sprite[] normalSprites;
    public Sprite[] cardsSprites;
    public Sprite[] textSprites;
    public Image[] sliderImages;
    public Image informationCards;
    public Image textCard;
   

    private void Start()
    {
        DeselectAll();
        ToogleInformationIcon(false);
    }

    public void SelectModel(int index)
    {
        soundManager.SendMessage("PlayClick");
        modelsManager.SendMessage("SetModel", index);
        // Setam toate imaginile sa fie selectate
        DeselectAll();
        sliderImages[index].sprite = selectedSprites[index];
        if(index != 6)
        {
            informationCards.sprite = cardsSprites[index];
            textCard.sprite = textSprites[index];
            ToogleInformationIcon(true);
        }
        else
        {
            ToogleInformationIcon(false);
        }
    }

    public void ShowInformation()
    {
        informationPanel.SetActive(true);
        soundManager.SendMessage("PlayClick");
    }

    public void HideInformationPanel()
    {
        informationPanel.SetActive(false);
        soundManager.SendMessage("PlayClick");   
    }

    private void DeselectAll()
    {
        for(int i = 0; i < sliderImages.Length; i++)
        {
            sliderImages[i].sprite = normalSprites[i];
        }
        ToogleInformationIcon(false);
    }

    private void ToogleInformationIcon(bool state)
    {
        informationIcon.SetActive(state);
    }
}