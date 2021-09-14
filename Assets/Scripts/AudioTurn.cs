using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTurn : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip turn;


    public void PlayTurnSound()
    {
        audioSource.PlayOneShot(turn);
    }

}
