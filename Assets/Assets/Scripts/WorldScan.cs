using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WorldScan : MonoBehaviour
{
    public GameObject forestArea;
    public GameObject desertArea;
    public GameObject aquaticArea;

    public AudioSource pickupAudioSource;

    public AudioClip pickupAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ForestPickup")
        {
            forestArea.SetActive(true);
            pickupAudioSource.Play();
        }

        if (other.gameObject.tag == "DesertPickup")
        {
            desertArea.SetActive(true);
            pickupAudioSource.Play();
        }

        if (other.gameObject.tag == "AquaticPickup")
        {
            aquaticArea.SetActive(true);
            pickupAudioSource.Play();
        }

    }
}
