using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource playerAudioSource;

    public AudioClip openWorldAudio;
    public AudioClip desertAudio;
    public AudioClip cityAudio;
    public AudioClip forestAudio;
    public AudioClip waterAudio;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Desert")
        {
            playerAudioSource.Stop();
            playerAudioSource.clip = desertAudio;
            playerAudioSource.Play();
        }

        if (other.gameObject.tag == "City")
        {
            playerAudioSource.Stop();
            playerAudioSource.clip = cityAudio;
            playerAudioSource.Play();
        }

        if (other.gameObject.tag == "Water")
        {
            playerAudioSource.Stop();
            playerAudioSource.clip = waterAudio;
            playerAudioSource.Play();
        }

        if (other.gameObject.tag == "Forest")
        {
            playerAudioSource.Stop();
            playerAudioSource.clip = forestAudio;
            playerAudioSource.Play();
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Desert")
        {
            playerAudioSource.Stop();
            playerAudioSource.clip = openWorldAudio;
            playerAudioSource.Play();
        }

        if (other.gameObject.tag == "City")
        {
            playerAudioSource.Stop();
            playerAudioSource.clip = openWorldAudio;
            playerAudioSource.Play();
        }

        if (other.gameObject.tag == "Water")
        {
            playerAudioSource.Stop();
            playerAudioSource.clip = openWorldAudio;
            playerAudioSource.Play();
        }

        if (other.gameObject.tag == "Forest")
        {
            playerAudioSource.Stop();
            playerAudioSource.clip = openWorldAudio;
            playerAudioSource.Play();
        }

    }

}
