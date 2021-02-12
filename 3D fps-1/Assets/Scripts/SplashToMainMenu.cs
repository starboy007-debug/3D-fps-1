
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{


    void Start()
    {
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
    }

}