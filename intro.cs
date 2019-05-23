using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour {

	
	void Start () {
        StartCoroutine(AcabarVideo());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator AcabarVideo()
    {
        yield return new WaitForSeconds(120f);
        SceneManager.LoadScene("Nivel1");
    }
}
