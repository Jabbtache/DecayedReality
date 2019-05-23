using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public static int health;
    public int numOfHearts;
	public GameObject gameOver;
	public GameObject vidas;
    
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject pinchos;
    public Animator anim;
    public PlayerMovement PlayerMovement;
    public GameObject skeleton;


    public GameObject Zombie;
    public bool attacked;

    private EnemyController EnemyController;
    private void Awake()
    {
        health = 4;
    }

    public void Start() {        
        pinchos.SetActive(true);
		gameOver.SetActive(false);
		vidas.SetActive(true);
        attacked = false;
        EnemyController = skeleton.GetComponent<EnemyController>();

    }

    public void Inmune()
    {
        pinchos.SetActive(false);
    }



    public void currHealth(){
		health= health -1;
	}

    IEnumerator w8()
    {
        yield return new WaitForSeconds(0.25f);
        Destroy(gameObject);
        gameOver.SetActive(true);
        vidas.SetActive(false);
    }

        void Update()
        {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

		if(health <= 0){
            StartCoroutine(w8());
           
		}


        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }


            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TakeDMG"))
        {
            health = health - 1;
            StartCoroutine(inmunity());

        }
        if (other.CompareTag("Skeleton"))
        {
            EnemyController enemy = other.GetComponent<EnemyController>();
            health = health - 5;
            StartCoroutine(inmunity());
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
                health = health - 1;
                StartCoroutine(inmunity());
        }
		 
    }
	


   IEnumerator inmunity()
    {
        
        PlayerMovement.runSpeed = 40f;
        anim.SetBool("inmunity", true);
        pinchos.SetActive(false);
        yield return new WaitForSeconds(1f);
        anim.SetBool("inmunity", false);
        attacked = false;
        pinchos.SetActive(true);
        PlayerMovement.runSpeed = 20f;
       

    }


}
