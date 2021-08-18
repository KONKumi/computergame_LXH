using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float moveSpeed = 1;
    public Animator animator;
    float fireRate = 1.0f;
    private float nextFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
 

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0)* moveSpeed * Time.deltaTime);
    }
}
