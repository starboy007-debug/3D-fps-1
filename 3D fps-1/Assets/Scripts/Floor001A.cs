using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor001A : MonoBehaviour
{
    public GameObject movableWall;

    void OnTriggerEnter(Collider other)
    {
        movableWall.GetComponent<Animator>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}