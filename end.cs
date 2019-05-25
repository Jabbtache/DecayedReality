using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AcabarVideo());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator AcabarVideo()
    {
        yield return new WaitForSeconds(45f);
        SceneManager.LoadScene("Menu");
    }
}
