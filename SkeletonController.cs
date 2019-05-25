using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour {

    public int health = 20;
    public Animator anim;
	
    void Start()
    {
      	 
    }
   

     public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
           Die();
        }

    }

    void Die()
    {
        anim.SetBool("IsDead", true);
       AI ai = GetComponent<AI>();
       ai.speed = 0f;
	   
	  
	  

    }

}
