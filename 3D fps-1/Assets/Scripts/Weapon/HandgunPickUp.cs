using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunPickUp : MonoBehaviour
{
    public GameObject Realhandgun;
    public GameObject Fakehandgun;
    public AudioSource pickupSound;
    public GameObject pickupDisplay;
    public GameObject Pistolimage;
    private void OnTriggerEnter(Collider other)
    {
        Realhandgun.SetActive(true);
        Fakehandgun.SetActive(false);
        pickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "HandGun";
        pickupDisplay.SetActive(true);
        Pistolimage.SetActive(true);
    }
}
