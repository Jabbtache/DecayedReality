using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMenuPause : MonoBehaviour {

    public string scene;
    public AudioSource myFx;
    public AudioClip hoverSound;

public void escena()
    {
        SceneManager.LoadScene(scene);
    }

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverSound);
    }
}
