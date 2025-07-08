using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{

    public GameObject mainmenuPanel;
    public GameObject settingPanel;
    public Slider volumeSlider;
    public AudioSource bgMusic;
    public Button settingButton;
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainmenu();
        settingButton.onClick.AddListener(ShowSetting);
        exitButton.onClick.AddListener(ShowMainmenu);
        volumeSlider.onValueChanged.AddListener(SetVolume);

        volumeSlider.value = bgMusic.volume;
    }

    public void ShowMainmenu()
    {
        mainmenuPanel.SetActive(true);
        settingPanel.SetActive(false);
    }
    public void ShowSetting()
    {
        mainmenuPanel.SetActive(false);
        settingPanel.SetActive(true);
    }

    public void SetVolume(float value)
    {
        bgMusic.volume = value;
    }
    
}
