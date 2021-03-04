using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour {

    public Animator animator;


    public static int SceneNumber;

	// Use this for initialization
	void Start () {
		if(SceneNumber == 0)
        {
            StartCoroutine(ToSplashTwo());
        }
     
    }
	
    IEnumerator ToSplashTwo ()
    {
        yield return new WaitForSeconds(3);


        SceneNumber = 1;
       SceneManager.LoadScene(1);

    }
}
