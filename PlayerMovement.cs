using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public GameObject mapa;
    public bool mapaActive;
    public int level;
    public int health;

	public Joystick joystick;
    public Button AttackButton;
    public Button shurikenButton;

    public GameObject chest;
    public int keys;


	

    // Update is called once per frame
    void Update() {  
	  keys = Chest.numberKeys;
        health = Health.health;
        level = SceneManager.GetActiveScene().buildIndex;

		 horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

         animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

         if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            animator.SetBool("isCrouching", true);
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
             
            if (Input.GetKeyDown(KeyCode.M))
            {
                mapa.SetActive(true);
                mapaActive = true;
            }


        if (Input.GetKeyDown(KeyCode.P)) 
        {
                pause.SetActive(true);
                pauseActive = true;
            runSpeed = 0f;
            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseActive == true) 
            {
                pause.SetActive(false);
                pauseActive = false;
                runSpeed = 20f;

            }
        }


    }
    public void OnCrouching(bool isCrouching) {
        animator.SetBool("isCrouching", isCrouching);
    }

    public void OnLanding() {

        animator.SetBool("IsJumping", false);

    }


    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }

    void Start() {
        mapa.SetActive(false);
        mapaActive = false;
        pause.SetActive(false);
        pauseActive = false;
    }

    public GameObject pause;
    public bool pauseActive;


    public void Resume()
    {
        pause.SetActive(false);
        pauseActive = false;
        runSpeed = 20f;
        joystick.enabled = true;
        AttackButton.interactable = true;
        shurikenButton.interactable = true;
    }

    public void pausa()
    {
        pause.SetActive(true);
        pauseActive = true;
        runSpeed = 0f;
        joystick.enabled = false;
        AttackButton.interactable = false;
        shurikenButton.interactable = false;
    }
           
    }



