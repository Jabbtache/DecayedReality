using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    public ParticleSystem particles;
	public GameObject GameOver;
	public string sceneName;
    public GameObject hearts;

	public GameObject joystick;
	public GameObject AttackButton;
	public GameObject shurikenButton;
	public GameObject pauseButton;
	

	void Start(){
	GameOver.SetActive(false);

	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
			Destroy(collision.gameObject);
			StartCoroutine(Muerte());
            
			//Destroy(collision.gameObject);
			//SceneManager.LoadScene(sceneName); 
			//GameObject instance = CFX_SpawnSystem.GetNextObject(particles);
			//instance.transform.position = player.position;
            
        }
    }

	IEnumerator LoadScene()
  {
        hearts.SetActive(false);

        //transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
		GameOver.SetActive(true);
}


IEnumerator Muerte(){
		yield return new WaitForSeconds(1.5f);
		GameOver.SetActive(true);
		joystick.SetActive(false);
		AttackButton.SetActive(false);
		shurikenButton.SetActive(false);
		pauseButton.SetActive(false);
}




}

