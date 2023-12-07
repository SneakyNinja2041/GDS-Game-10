using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AnimalTracker : MonoBehaviour
{
    public static int animalCount;
    public GameObject addedAnimal;
    public TextMeshProUGUI animalCounter;
    public GameObject animalText;

    void Start()
    {
        animalText.SetActive(false);
    }

    void Update()
    {
        animalCounter.text = "Animals Collected : " + animalCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.tag == "Pickup")
         {
            addedAnimal = other.gameObject;

            animalCount++;

         }

         if(other.gameObject.tag == "Player")
         {
            animalText.SetActive(true);
         }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Pickup")
        {
            addedAnimal = other.gameObject;

            animalCount--;
        }

        if(other.gameObject.tag == "Player")
        {
            animalText.SetActive(false);
        }

    }



}
