
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTranstitionNew : MonoBehaviour {





    public Animator animator;


    public static int SceneNumber;

    // Use this for initialization
   

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Scene Transistion");

        StartCoroutine(ToSplashTwo());
    }

    IEnumerator ToSplashTwo()
    {
        yield return new WaitForSeconds(3);


        SceneNumber = 1;
        SceneManager.LoadScene(1);

    }
}


