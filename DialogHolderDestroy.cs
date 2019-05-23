using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolderDestroy : MonoBehaviour {

    public string dialog;
    private DialogManager dMan;
    public string[] dialogueLines;

	// Use this for initialization
	void Start () {
        dMan = FindObjectOfType<DialogManager>();
		}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            //if (Input.GetKeyDown(KeyCode.E))
            //{
                //dMan.ShowBox(dialog);

                if (!dMan.dialogActive)
                {
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
					Destroy(gameObject);
                }
            //}
        }
    }
	void OnTriggerExit2D(Collider2D other)
    {
        dMan.DontShowBox(dialog);
           
    }
}
