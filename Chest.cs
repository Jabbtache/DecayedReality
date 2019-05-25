using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour {

	public Animator anim;
    public GameObject key;
    public bool isOpened;
    public GameObject keysUI;
    public Text numKeys;
	public static int numberKeys;


	void Start(){
	anim.SetBool("isOpened", false);
        key.SetActive(false);
        anim.SetBool("opened", false);
        isOpened = false;
        //keysUI.SetActive(false);
		numKeys.text = "x" + numberKeys.ToString();

}


void OnCollisionStay2D(Collision2D other){
	 if(other.gameObject.name == "Player"){
	 	 if(Input.GetKeyDown(KeyCode.E)){
		StartCoroutine(chest());
		anim.SetBool("isOpened", true);
        isOpened = true;
        key.SetActive(true);
        numberKeys = numberKeys + 1;
		Debug.Log(numberKeys);
        keysUI.SetActive(true);
        SetCountText();
            }
	 }
	}
	IEnumerator chest(){
	anim.SetBool("opening", true);
	yield return new WaitForSeconds(0.1f);
    Destroy(key);

    }
    void SetCountText()
    {
        numKeys.text = "x" + numberKeys.ToString();
    }
}
