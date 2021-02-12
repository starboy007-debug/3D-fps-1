using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HandgunAmmoPick : MonoBehaviour
{

    public GameObject fakeAmmoClip;
    public AudioSource ammoPickupSound;
    public GameObject pickupDisplay;

    void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false);
        ammoPickupSound.Play();
        GlobalAmmo.handgunAmmo += 10;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "Clip of bullets";
        pickupDisplay.SetActive(true);
    }

}



