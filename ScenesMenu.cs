using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMenu : MonoBehaviour {

    public string scene;
    public AudioSource myFx;
    public AudioClip hoverSound;

    public string nextLevel = "Nivel2";
    public int levelToUnlock = 2;
    public int hola;

public void escena()
    {
        
        SceneManager.LoadScene(scene);
    }

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverSound);
    }

    public void WinLevel()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
       
    } 
	public void Update(){
		Debug.Log(hola);
	}

	void Start(){
		hola =  PlayerPrefs.GetInt("levelReached", levelToUnlock);
	}


}
