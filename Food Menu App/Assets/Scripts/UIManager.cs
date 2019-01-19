using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
// Class: UIManager
// Desc: Contine toate metodele pentru functionalitatea
//       sistemului de navgare in meniul aplicatiri.
// _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
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
    public GameObject UserInfo;
    public GameObject UserInfoChoose;
    private string saveInfoUser = "sfu";
    private string saveInfoUserChoose = "sfuc";

    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    // Method: Start
    // Desc: Folosita pentru initializarea referintelor atunci
    //       cand aplicatia porneste.
    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    private void Start()
    {
        DeselectAll();
        ToogleInformationIcon(false);
        PlayerPrefs.GetString(saveInfoUser, "InfoUserSave");
        PlayerPrefs.GetString(saveInfoUserChoose, "InfoUserSaveChose");
    }

    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    // Method: SetModel
    // Desc: Folosita pentru apelarea functiti PlayClick din 
    //       scriptul SoundManager. Dezactivarea tuturor 
    //       imaginilor.
    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    public void SelectModel(int index)
    {
        soundManager.SendMessage("PlayClick");
        modelsManager.SendMessage("SetModel", index);
        PlayerPrefs.GetString(saveInfoUserChoose, "InfoUserSaveChose");
        // Setam toate imaginile sa fie selectate
        DeselectAll();
        sliderImages[index].sprite = selectedSprites[index];
        if(index != 6)
        {
            informationCards.sprite = cardsSprites[index];
            textCard.sprite = textSprites[index];
            PlayerPrefs.GetString(saveInfoUser, "InfoUserSave");
            ToogleInformationIcon(true);
            //EnableInfo();
        }
        else
        {
            ToogleInformationIcon(false);
        }
    }

    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    // Method: ShowInformation
    // Desc: Folosita pentru afisarea ferestrei de informatii
    // despre meniu atunci cand utilizatorul apasa pe butonul
    // de informatii.
    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    public void ShowInformation()
    {
        informationPanel.SetActive(true);
        soundManager.SendMessage("PlayClick"); // Apeleaza functia PlayClick din scriptul SoundManager.
    }

    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    // Method: MainMenu
    // Desc: Folosita pentru accesarea meniului aplicatiei.
    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    public void MainMenu()
    {
        soundManager.SendMessage("PlayClick"); // Apeleaza functia PlayClick din scriptul SoundManager.
        SceneManager.LoadSceneAsync(0);
    }

    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    // Method: HideInformationPanel
    // Desc: Folosita pentru inchiderea feresteri de informatii
    //       a meniului.
    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    public void HideInformationPanel()
    {
        informationPanel.SetActive(false);
        soundManager.SendMessage("PlayClick");   
    }

    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    // Method: DeselectAll
    // Desc: Folosita pentru dezactivarea imaginilor din
    //       contentul cu meniuri, astfel incat atunci cand
    //       utilizatorul selecteaza alt meniu, celalalte meniuri
    //       sunt dezactivate si ramane activat foar meniul selectat
    //      care este incadrat cu un contur albastru.
    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    private void DeselectAll()
    {
        for(int i = 0; i < sliderImages.Length; i++)
        {
            sliderImages[i].sprite = normalSprites[i];
        }
        ToogleInformationIcon(false);
    }

    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    // Method: ToogleInformtionIcon
    // Desc: Folosita pentru activarea sau dezactivarea conturului
    //       de albastru care indica utilizatorului daca imaginea
    //       este selectat sau nu.
    // _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    private void ToogleInformationIcon(bool state)
    {
        informationIcon.SetActive(state);
    }

    private void  EnableInfo()
    {
        if (saveInfoUser != "sfu")
        {
            UserInfo.SetActive(true);
        }
        else
        {
            StartCoroutine(DesableInfoTime());
        }

        if(saveInfoUserChoose != "sfuc")
        {
            UserInfoChoose.SetActive(true);
        }
        else
        {
            StartCoroutine(DesableInfoTime());
        }
    }

    IEnumerator DesableInfoTime()
    {
        if (saveInfoUser == "sfu")
        {
            PlayerPrefs.SetString(saveInfoUser, "InfoUserSave");
            yield return new WaitForSeconds(2f);
            UserInfo.SetActive(false);
        }

        if(saveInfoUserChoose == "sfuc")
        {
            PlayerPrefs.SetString(saveInfoUserChoose, "InfoUserSaveChose");
            yield return new WaitForSeconds(2f);
            UserInfoChoose.SetActive(false);
        }
    }
}