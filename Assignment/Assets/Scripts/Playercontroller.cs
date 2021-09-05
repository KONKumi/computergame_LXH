using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float moveSpeed = 1;
    public Animator animator;
    float fireRate = 1.0f;
    private float nextFire;
    GameController gc;
    private Rigidbody2D rb;
    static AudioSource audioSrc;
    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
         audioSrc.Play(0);
       
        
    }

    // Update is called once per frame
    void isStop()
    {
        if (horizontalInput == 0 && verticalInput == 0)
            audioSrc.Pause();
    }

    void isMoving()
    {
        if (horizontalInput != 0 || verticalInput != 0)
            audioSrc.UnPause();

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Gangster"))
        {
            ChasePlayer enemyChase = other.gameObject.GetComponent<ChasePlayer>();
            enemyChase.moveSpeed = 0;
            gc.attackPlayer(1f);
        }
        else if(other.gameObject.CompareTag("Cadre"))
        {
            ChasePlayer enemyChase = other.gameObject.GetComponent<ChasePlayer>();
            enemyChase.moveSpeed = 0;
            gc.attackPlayer(1f);
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("FireBall"))
        {

            gc.attackPlayer(2f);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
      
        if (other.gameObject.CompareTag("Gangster"))
        {
            ChasePlayer enemyChase = other.gameObject.GetComponent<ChasePlayer>();
            enemyChase.moveSpeed = 1;

        }
        else if(other.gameObject.CompareTag("Cadre"))
        {
            ChasePlayer enemyChase = other.gameObject.GetComponent<ChasePlayer>();
            enemyChase.moveSpeed = 1;

        }

    }


    void Update()
    {
       
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("Attack", Input.GetAxis("Attack"));
        animator.SetFloat("AttackWeapon", Input.GetAxis("AttackWeapon"));

        if (Input.GetButton("AttackWeapon") && Time.time > nextFire)
        {
            //If the player fired, reset the NextFire time to a new point in the future.
            nextFire = Time.time + fireRate;
          

            //Weapon firing logic goes here.


            Debug.Log("Firing once every 1s");
        }

        
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");


        isMoving();
        isStop();

        rb.velocity = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);
    }

   
}
