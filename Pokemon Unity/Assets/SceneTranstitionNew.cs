
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTranstitionNew : MonoBehaviour {





    public Animator animator;


    public static int SceneNumber;

    // Use this for initialization


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Scene Transistion");
        SceneManager.LoadScene(1);
    }


}


