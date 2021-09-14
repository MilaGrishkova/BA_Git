using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    private float Long, Power, Fast;
    public Player player;
    public Text coinText;
    public Text boxText;
    public Text starText;
    public Image[] hearts;
    public Sprite isLife, nonLife;
    public GameObject PauseScreen;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public AudioCollection audioCollect;
    public AudioSource musicSourse, soundSourse;
    private AudioSource[] allAudioSources;



    public void Reloadlvl()
    {
        //https://www.youtube.com/watch?v=NdPICO-pJpg
        //https://www.youtube.com/watch?v=zc8ac_qUXQY
        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    private void Start()
    {
        //https://www.youtube.com/watch?v=3I5d2rUJ0pE
        //https://www.youtube.com/watch?v=tWUyEfD0kV0 
        //https://www.youtube.com/watch?v=nTLgzvklgU8

        musicSourse.volume =
       (float)PlayerPrefs.GetInt("MusicVolume") / 9;
        soundSourse.volume =
       (float)PlayerPrefs.GetInt("SoundVolume") / 9;

    }


    private void LateUpdate()
    {
        //https://www.youtube.com/watch?v=8PXPyyVu_6I&t=504s

        if (Long > 0)
        {
            Long -= Time.deltaTime;

            float xAmount = Random.Range(-1f, 1f) * Power;
            float yAmount = Random.Range(-1f, 1f) * Power;

            transform.position += new Vector3(xAmount, yAmount, 0f);
            Power = Mathf.MoveTowards(Power, 0f, Fast * Time.deltaTime);
        }
    }



    public void StartShake(float length, float power)
    {
        //https://www.youtube.com/watch?v=8PXPyyVu_6I&t=504s

        Long = length;
        Power = power;
        Fast = power / length;
    }


    public void Update()
    {
        //https://www.youtube.com/watch?v=-EIXQHxoicg
        //https://www.youtube.com/watch?v=DZ-3g31jk90
        //https://www.youtube.com/watch?v=6Z_n0xkIZI4&t=958s
        //https://www.youtube.com/watch?v=Y5WVxdhEiIg

        coinText.text = player.GetCoins().ToString();
        boxText.text = player.GetBox().ToString();
        starText.text = player.GetStar().ToString();

        for (int i = 0; i < hearts.Length; i++)
        {
            if (player.GetHeart() > i)
                hearts[i].sprite = isLife;
            else
                hearts[i].sprite = nonLife;

        }
    }


    public void PauseOn()
    { //https://www.youtube.com/watch?v=tfzwyNS1LUY
        Time.timeScale = 0f;
        player.enabled = false;
        PauseScreen.SetActive(true);
    }


    public void PauseOff()
    {//https://www.youtube.com/watch?v=tfzwyNS1LUY
        Time.timeScale = 1f;
        player.enabled = true;
        PauseScreen.SetActive(false);
    }

    public void Win()
    {
        //https://www.youtube.com/watch?v=agzcdg7CceU
        //https://www.youtube.com/watch?v=_21eUOhtjK4&t=61s

        Time.timeScale = 0f;
        player.enabled = false;
        WinScreen.SetActive(true);
        StartShake(0.3f, 0.3f);
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }


        audioCollect.PlayWinSound();


        if (!PlayerPrefs.HasKey("Lvl") ||
       PlayerPrefs.GetInt("Lvl") <
        SceneManager.GetActiveScene().buildIndex)
            PlayerPrefs.SetInt("Lvl",
       SceneManager.GetActiveScene().buildIndex);


        if (PlayerPrefs.HasKey("coins"))
            PlayerPrefs.SetInt("coins",
        PlayerPrefs.GetInt("coins") + player.GetCoins());
        else
            PlayerPrefs.SetInt("coins", player.GetCoins());

        print(PlayerPrefs.GetInt("coins"));

        if (PlayerPrefs.HasKey("box"))
            PlayerPrefs.SetInt("box", PlayerPrefs.GetInt("box")
      + player.GetBox());
        else
            PlayerPrefs.SetInt("box", player.GetBox());

        print(PlayerPrefs.GetInt("box"));

        if (PlayerPrefs.HasKey("star"))
            PlayerPrefs.SetInt("star",
           PlayerPrefs.GetInt("star") + player.GetStar());
        else
            PlayerPrefs.SetInt("star", player.GetStar());

        print(PlayerPrefs.GetInt("star"));

    }



    public void Lose()
    {
        //https://www.youtube.com/watch?v=K4uOjb5p3Io
        //https://www.youtube.com/watch?v=Pv1Bi6ao_J8
        Time.timeScale = 0f;
        player.enabled = false;
        StartShake(0.3f, 0.3f);
        LoseScreen.SetActive(true);

    }

    public void MenuLvl()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene("Menu");
    }

    public void NextLvl()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 

}
