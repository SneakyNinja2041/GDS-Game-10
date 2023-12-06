using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTracker : MonoBehaviour
{


    public int animalCount;

    public GameObject addedAnimal;

    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.tag == "Pickup")
         {
            addedAnimal = other.gameObject;
            animalCount++;
         }
    }

    private void OnTriggerExit(Collider other)
    {
        animalCount--;


    }



}
