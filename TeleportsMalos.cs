﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TeleportsMalos : MonoBehaviour {

public Animator anim;
public string sceneName;


public void OnCollisionStay2D(Collision2D other)
{
Debug.Log(other.gameObject.tag);
    if (other.gameObject.tag == "Player")
    {
           
            StartCoroutine(LoadScene());
			//SceneManager.LoadScene(sceneName); 

    }
}


public void OnCTriggerStay2D(Collision2D other)
{
	

    if (other.gameObject.tag == "Player")
    {
            
            StartCoroutine(LoadScene());
			//SceneManager.LoadScene(sceneName); 

    }
}

public void OnCollisionExit2D(Collision2D other)
{
    if (other.gameObject.tag == "Player")
    {
           anim.SetTrigger("noeffect");
   }
}


   IEnumerator LoadScene()
  {
        anim.SetTrigger("effect");
        yield return new WaitForSeconds(1.1f);
		SceneManager.LoadScene(sceneName);
	}
    }
