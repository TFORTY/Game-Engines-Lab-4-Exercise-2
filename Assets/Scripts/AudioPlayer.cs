using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Movement.enemyKilled += PlayAudio;
    }

    private void OnDisable()
    {
        Movement.enemyKilled -= PlayAudio;
    }

    private void PlayAudio()
    {
        audioSource.Play();
    }
}