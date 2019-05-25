using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    public int dmg = 60;

    void Start () {

        rb.velocity = transform.right * speed;

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        EnemyController enemy = other.GetComponent<EnemyController>();

        if( enemy != null)
        {
            other.SendMessageUpwards("Damage", dmg);
        }

        Destroy(gameObject);
    }



    
}
