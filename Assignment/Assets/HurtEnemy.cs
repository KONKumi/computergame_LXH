using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    private Animator parent;
    bool isAttack;
    GameObject enemy;
    float fireRate = 0.5f;
    private float nextFire;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        parent = GetComponentInParent<Animator>();
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Attack"))
        {
            isAttack = true;
            parent.SetBool("Attack", true);
        }

        if (Input.GetButtonUp("Attack"))
        {
            isAttack = false;
        }
    }

  

    void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Gangster"))
         {
            if (Input.GetButton("Attack") && Time.time > nextFire)
            {
                if (isAttack)
            {
               
                    //If the player fired, reset the NextFire time to a new point in the future.
                    nextFire = Time.time + fireRate;

                    GangsterHp.gangsterhp -= 2f;
                    //Weapon firing logic goes here.        

                    audioSrc.Play(0);
          
                }
                
            }
        }

        else if(other.gameObject.CompareTag("Cadre"))
         {
            if (Input.GetButton("Attack") && Time.time > nextFire)
            {
                if (isAttack)
                {

                    //If the player fired, reset the NextFire time to a new point in the future.
                    nextFire = Time.time + fireRate;

                    monsterHp.cadrehp -= 2f;
                    //Weapon firing logic goes here.        

                    audioSrc.Play(0);

                }

            }
        }
        else if (other.gameObject.CompareTag("Satan"))
        {
            if (Input.GetButton("Attack") && Time.time > nextFire)
            {
                if (isAttack)
                {

                    //If the player fired, reset the NextFire time to a new point in the future.
                    nextFire = Time.time + fireRate;

                    monsterHp.satanhp -= 2f;
                    //Weapon firing logic goes here.        

                    audioSrc.Play(0);

                }

            }
        }
    }
}
