using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBuletPlayer : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip destroy;

    public void PlayDestroy()

    {
        audioSource.PlayOneShot(destroy);
    }


}