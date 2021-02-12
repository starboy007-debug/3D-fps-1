using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{

    public GameObject theDoor;
    public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorOpen");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(Closedoor());
    }

    IEnumerator Closedoor()
    {
        yield return new WaitForSeconds(5f);
        doorFX.Play();
        this.GetComponent<BoxCollider>().enabled = true;
        theDoor.GetComponent<Animator>().Play("DoorClose");
    }

}