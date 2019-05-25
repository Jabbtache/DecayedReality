using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public int health = 100;
    public Animator anim;
	public GameObject chest;
    public BoxCollider2D hitbox;
    public CircleCollider2D trigger;
    public CapsuleCollider2D capsule;
    public bool isAlive;
    public CircleCollider2D circle;
	




    void Start()
    {

	
        isAlive = true;
        capsule.enabled = false;
       chest.SetActive(false);
        hitbox.enabled = true;
        trigger.enabled = true;

	   //AI ai = GetComponent<AI>();
       // ai.speed = ai.speed +0;
	 
    }


    // IEnumerator destroy()
    //{

    // anim.SetBool("isdead", true);
    // yield return new WaitForSeconds(0.2f);
    // Destroy(gameObject);
    //}
    private void Update()
    {
        if(isAlive == true)
        {
            capsule.enabled = false;
            hitbox.enabled = true;
            trigger.enabled = true;
        }
    }


    public void Damage(int dmg)
    {
		
        health -= dmg;
        if (health <= 0)
        {
            chest.SetActive(true);
            Die();
        }

    }

	
		
    void Die()
    {
        isAlive = false;
        anim.SetBool("IsRunning", false);
        anim.SetBool("IsAttacking", false);
        anim.SetBool("IsDead", true);
       AI ai = GetComponent<AI>();
       ai.speed = 0f;
        hitbox.enabled = false;
        trigger.enabled = false;
        capsule.enabled = true;

        //chest.SetActive(true);



    }


    public void disable()
    {
        trigger.enabled = false;
    }

    public void enable()
    {
        trigger.enabled = true;
    }

    /*IEnumerator disble()
    {
        
        yield return new WaitForSeconds(1f);
        trigger.enabled = true;
    }
    */
}
