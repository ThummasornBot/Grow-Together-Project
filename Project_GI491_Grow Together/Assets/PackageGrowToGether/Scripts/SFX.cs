using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource playSFX;
    public AudioSource quitSFX;
    public AudioSource questInMapSFX;
    public AudioSource questInHomeSFX;

    public void PlayButton()
    {
        playSFX.Play();
    }

    public void QuitButton()
    {
        quitSFX.Play();
    }

    public void QuestInMapButton()
    {
        questInMapSFX.Play();
    }

    public void QuestInHomeButton()
    {
        questInHomeSFX.Play();
    }
}
