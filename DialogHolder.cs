using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogHolder : MonoBehaviour {

    public string dialog;
    private DialogManager dMan;
    public string[] dialogueLines;
    public GameObject e;
	public Button buttonE;

	// Use this for initialization
	void Start () {
        dMan = FindObjectOfType<DialogManager>();
        e.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
       if (other.gameObject.name == "Player")
        {
            e.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                //dMan.ShowBox(dialog);

                if (!dMan.dialogActive)
                {
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
            }
        }
    }
	void OnTriggerExit2D(Collider2D other)
    {
        dMan.DontShowBox(dialog);
        e.SetActive(false);
    }


	public void dialogo()
	{
		   if (!dMan.dialogActive)
                {
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
	}
                //dMan.ShowBox(dialog);
			


                
    }
	


	

	

