using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollection : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip enemyDead, saw, bullet, keySound, doorSound, shakerSound, hiHatSound,  kickSound, snareSound, jumpSound, coinSound, coin1Sound, 
        turururuSound, winSound, loseSound, markBox, heartSound, painSound, killSound, starSound, inWater, ground1, ground2, ground3, ground4, ground5, intro, intro2, groundD, groundD2, stepSound, trampoline, water;



    public void PlayEnemyDeadSound()

    {
        audioSource.PlayOneShot(enemyDead);
    }

    public void PlayInWater()
    {
        audioSource.PlayOneShot(inWater);
    }

    public void PlaySaw()
    {
        audioSource.PlayOneShot(saw);
    }

    public void PlayBulletSound()
    {
        audioSource.PlayOneShot(bullet);
    }

    public void PlayStepSound()
    {
        audioSource.PlayOneShot(stepSound);
    }

    public void PlayKeySound()
    {
        audioSource.PlayOneShot(keySound);
    }

    public void PlayDoorSound()

    {
        audioSource.PlayOneShot(doorSound);
    }

    public void PlayShakerSound()
    {
        audioSource.PlayOneShot(shakerSound);
    }

    public void PlayHiHatSound()

    {
        audioSource.PlayOneShot(hiHatSound);
    }

    public void PlayKickSound()
    {
        audioSource.PlayOneShot(kickSound);
    }

    public void PlaySnareSound()
    {
        audioSource.PlayOneShot(snareSound);
    }
  
    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpSound);
    }

    public void PlayCoinSound()
    {
        audioSource.PlayOneShot(coinSound);
    }

    public void PlayCoin1Sound()
    {
        audioSource.PlayOneShot(coin1Sound);
    }

    
    public void PlayTurururuSound()
    {
        audioSource.PlayOneShot(turururuSound);
    }

    public void PlayWinSound()
    {
        audioSource.loop = true;
        audioSource.PlayOneShot(winSound);
    }

    public void PlayLoseSound()
    {
        audioSource.PlayOneShot(loseSound);
    }

    public void PlayMarkBox()

    {
        audioSource.PlayOneShot(markBox);
    }

    public void PlayHeartSound()
    {
        audioSource.PlayOneShot(heartSound);
    }

    public void PlayPainSound()
    {
        audioSource.PlayOneShot(painSound);
    }

    public void PlayKillSound()
    {
        audioSource.PlayOneShot(killSound);
    }


    public void PlayStar()

    {
        audioSource.PlayOneShot(starSound);
    }

    public void PlayGround1()
    {
        audioSource.PlayOneShot(ground1);
    }

    public void PlayGround2()
    {
        audioSource.PlayOneShot(ground2);
    }

    public void PlayGround3()
    {
        audioSource.PlayOneShot(ground3);
    }

    public void PlayGround4()
    {
        audioSource.PlayOneShot(ground4);
    }

    public void PlayGround5()
    {
        audioSource.PlayOneShot(ground5);
    }

    public void PlayIntro()
    {
        audioSource.PlayOneShot(intro);
    }

    public void PlayIntro2()
    {
        audioSource.PlayOneShot(intro2);

    }

    public void PlayGroundD()
    {
        audioSource.PlayOneShot(groundD);
    }

    public void PlayGroundD2()
    {
        audioSource.PlayOneShot(groundD2);
    }


    public void PlayTrampoline()

    {
        audioSource.PlayOneShot(trampoline);
    }


    public void PlayWaterSound()
    {
        audioSource.PlayOneShot(water);
    }

}
