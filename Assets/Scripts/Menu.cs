using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    //https://www.youtube.com/watch?v=8wcEOoLTwOE
    public Button[] lvls;
    public Text coinText;
    public Text boxText;
    public Text starText;
    public Slider musicSlider, soundSlider;
    public Text musicText, soundText;


    void Start()
    { //https://www.youtube.com/watch?v=_21eUOhtjK4&t=61s

        if (PlayerPrefs.HasKey("Lvl"))
            for (int i = 0; i < lvls.Length; i++)
            {
                if (i <= PlayerPrefs.GetInt("Lvl"))
                    lvls[i].interactable = true;
                else
                    lvls[i].interactable = false;
            }

        if (!PlayerPrefs.HasKey("hp"))
            PlayerPrefs.SetInt("hp", 0);
        if (!PlayerPrefs.HasKey("bg"))
            PlayerPrefs.SetInt("bg", 0);
        if (!PlayerPrefs.HasKey("gg"))
            PlayerPrefs.SetInt("gg", 0);



        if (!PlayerPrefs.HasKey("MusicVolume"))
            PlayerPrefs.SetInt("MusicVolume", 3);
        if (!PlayerPrefs.HasKey("SoundVolume"))
            PlayerPrefs.SetInt("SoundVolume", 5);

        musicSlider.value = PlayerPrefs.GetInt("MusicVolume");
        soundSlider.value = PlayerPrefs.GetInt("SoundVolume");

    }


    void Update()
    {
        PlayerPrefs.SetInt("MusicVolume",
       (int)musicSlider.value);
        PlayerPrefs.SetInt("SoundVolume",
       (int)soundSlider.value);
        musicText.text = musicSlider.value.ToString();
        soundText.text = soundSlider.value.ToString();

        if (PlayerPrefs.HasKey("coins"))
            coinText.text = PlayerPrefs.GetInt("coins").ToString();
        else
            coinText.text = "0";

        if (PlayerPrefs.HasKey("box"))
            boxText.text = PlayerPrefs.GetInt("box").ToString();
        else
            boxText.text = "0";
        if (PlayerPrefs.HasKey("star"))
            starText.text = PlayerPrefs.GetInt("star").ToString();
        else
            starText.text = "0";
    }

    public void OpenScene(int index)
    {

        SceneManager.LoadScene(index);
    }

    public void DelKeys()
    {
        PlayerPrefs.DeleteAll();
    }

}


