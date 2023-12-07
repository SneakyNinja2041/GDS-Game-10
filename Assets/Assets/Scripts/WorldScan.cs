using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WorldScan : MonoBehaviour
{
    public GameObject forestArea;
    public GameObject desertArea;
    public GameObject aquaticArea;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ForestPickup")
        {
            forestArea.SetActive(true);
        }

        if (other.gameObject.tag == "DesertPickup")
        {
            desertArea.SetActive(true);
        }

        if (other.gameObject.tag == "AquaticPickup")
        {
            aquaticArea.SetActive(true);
        }

    }
}
