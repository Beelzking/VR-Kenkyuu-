using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

public class HandMenu : MonoBehaviour
{
    

    private bool active = false;

    public void ChangeLocale(int localeID)
    {
        if (active == true)
        {
            return;
        }
        StartCoroutine(SetLocale(localeID));
    }

    IEnumerator SetLocale(int _localeID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        PlayerPrefs.SetInt("LocaleKey", _localeID);
        active = false;
    }

    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject options;


    [Header("Main Menu Buttons")]
    public Button optionButton;
    public Button quitButton;
    public List<Button> returnButtons;

    void Start()
    {
        EnableMainMenu();

        //Hook events
        optionButton.onClick.AddListener(EnableOption);
        quitButton.onClick.AddListener(QuitGame);

        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableMainMenu);
        }

    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void HideAll()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
       
    }

    public void EnableMainMenu()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
       
    }
    public void EnableOption()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
    
    }


}


