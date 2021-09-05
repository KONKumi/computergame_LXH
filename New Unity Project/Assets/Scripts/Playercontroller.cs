using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float moveSpeed = 1;
    public Animator animator;
    private Rigidbody2D rb;
    GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("Attack", Input.GetAxis("Attack"));

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);
     
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            ZombiePatrol enemyPatrol = other.gameObject.GetComponent<ZombiePatrol>();
            enemyPatrol.moveSpeed = 0;
            gc.attackPlayer(1f);
        }
        else if (other.gameObject.CompareTag("ChaseEnemy"))
        {
            ChasePlayer enemyChase = other.gameObject.GetComponent<ChasePlayer>();
            enemyChase.moveSpeed = 0;
            gc.attackPlayer(2f);
        }
        else if (other.gameObject.CompareTag("FollowEnemy"))
        {
            FollowPath enemyFollow = other.gameObject.GetComponent<FollowPath>();
            enemyFollow.moveSpeed = 0;
            gc.attackPlayer(0.5f);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            ZombiePatrol enemyPatrol = other.gameObject.GetComponent<ZombiePatrol>();
            enemyPatrol.moveSpeed = 1;
          
        }
        else if (other.gameObject.CompareTag("ChaseEnemy"))
        {
            ChasePlayer enemyChase = other.gameObject.GetComponent<ChasePlayer>();
            enemyChase.moveSpeed = 1;
          
        }
        else if (other.gameObject.CompareTag("FollowEnemy"))
        {
            FollowPath enemyFollow = other.gameObject.GetComponent<FollowPath>();
            enemyFollow.moveSpeed = 1;
           
        }
    }

}
