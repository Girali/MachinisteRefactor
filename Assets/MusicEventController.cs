using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEventController : MonoBehaviour
{
    public AudioClip titleScreen;
    public AudioClip act1Intro;
    public AudioClip act1Loop;
    public AudioClip act2Intro;
    public AudioClip act2Loop;
    public AudioClip act3Intro;
    public AudioClip act3Loop;
    public AudioClip credit;

    public void PlayMusicSequence(AudioClip s, AudioClip ss)
    {
        audioSource.clip = s;
        audioSource.loop = false;
        audioSource.Play();
        StartCoroutine(CRT_PlayMusicSequence(ss));
    }

    public void PlayMusic(AudioClip s)
    {
        audioSource.clip = s;
        audioSource.loop = false;
        audioSource.Play();
    }

    IEnumerator CRT_PlayMusicSequence(AudioClip s)
    {
        yield return new WaitUntil(() => audioSource.isPlaying);
        audioSource.clip = s;
        audioSource.loop = true;
        audioSource.Play();
    }

    public AudioSource audioSource;


    private static MusicEventController _instance = null;

    public static MusicEventController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<MusicEventController>();
            return _instance;
        }
    }
}
