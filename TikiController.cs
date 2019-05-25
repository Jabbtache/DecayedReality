using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TikiController : MonoBehaviour {

    public int health = 100;
    public Animator anim;
	public GameObject chest;

    void Start()
    {
       chest.SetActive(false);
	   //AI ai = GetComponent<AI>();
       // ai.speed = ai.speed +0;
	 
    }
   

     IEnumerator destroy()
    {

       anim.SetBool("isdead", true);
       yield return new WaitForSeconds(0.2f);
       Destroy(gameObject);
    }

    public void Damage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
           StartCoroutine(destroy());
        }

    }

    void Die()
    {
        anim.SetBool("isdead", true);
       AI ai = GetComponent<AI>();
       ai.speed = 0f;
	   chest.SetActive(true);
	  
	  

    }

}
