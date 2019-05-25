using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    public string Scene;
    public GameObject key;

    void Start()
    {
        key.SetActive(false);
	
    }


    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other);
        if (other.gameObject.name == "Player")
        {
                if (Chest.numberKeys >= 1)
                {
                    key.SetActive(true);
                    SceneManager.LoadScene(Scene);
                    Chest.numberKeys = Chest.numberKeys - 1;
                }
            
        }
    }


void Update()
{
Debug.Log(Chest.numberKeys);
}


}