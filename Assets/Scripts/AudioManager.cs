using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public AudioSource audioSource;
    public AudioClip birdFlap;
    public AudioClip birdDie;
    public AudioClip birdAddScore;
    public AudioClip bgMusic;


    private void Start()
    {
        audioSource.clip = bgMusic;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayAudioFlap()
    {
        audioSource.PlayOneShot(birdFlap);
    }
    public void PlayAudioDie()
    {
        audioSource.PlayOneShot(birdDie);
    }
    public void PlayAudioAddScore()
    {
        audioSource.PlayOneShot(birdAddScore);
    }
}
