using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{

    public GameObject dBox;
    public TextMeshProUGUI dText;

    public bool dialogActive;

    public string[] dialogLines;
    public int currentLine;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {

            // dBox.SetActive(false);
            // dialogActive = false;
            //StartCoroutine(wait());
            currentLine++;
        }

        if (currentLine >= dialogLines.Length)
        {
            dBox.SetActive(false);
            dialogActive = false;
            currentLine = 0;
        }
        dText.text = dialogLines[currentLine];
    }


    public void ShowBox(string dialog)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialog;
    }

    public void ShowDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
    }

    public void DontShowBox(string dialog)
    {
        dialogActive = false;
        dBox.SetActive(false);
    }


    void OnMouseDown()
    {



    }
}