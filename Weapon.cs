using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject shuriken;
    public Animator anim;
    public Button shurikenButton;


    public bool shooting = false;
    private float shootTimer = 0;
    private float shootCd = 0.3f;

    void Start()
    {
        shooting = false;
        shurikenButton.onClick.AddListener(TaskClick);
    }

    // Update is called once per frame

    void TaskClick()
    {
        shooting = true;
        Instantiate(shuriken, firePoint.position, firePoint.rotation);
        shootTimer = shootCd;
    }

    void Update () {

        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        
        }



        if (Input.GetMouseButtonDown(1) && !shooting)
        {
            shooting = true;
            shootTimer = shootCd;
            
        }

        if (shooting)
        {
            if (shootTimer > 0)
            {
                shootTimer -= Time.deltaTime;
            }
            else
            {
                shooting = false;
            }
        }

        anim.SetBool("shooting", shooting);

      


    }


void Shoot()
    {        
               Instantiate(shuriken, firePoint.position, firePoint.rotation);
      
    }

     
}
