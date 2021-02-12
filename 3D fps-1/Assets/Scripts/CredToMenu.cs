using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CredToMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(BackToMenu());
    }

    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(11);
        SceneManager.LoadScene(3);
    }

}