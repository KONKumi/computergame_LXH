using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Animator parent;
    static AudioSource audioSrc;

    public GameObject Front;
    public GameObject Back;
    public GameObject Right;
    public GameObject Left;
    Vector2 where;
    float fireRate = 1.5f;
    private float nextFire;


    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.GetComponentInParent<Animator>();

        audioSrc = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        int AttackWeapon = parent.GetInteger("moveDir");

        
            if (Time.time > nextFire)
            {

                //If the player fired, reset the NextFire time to a new point in the future.
                nextFire = Time.time + fireRate;
                if (AttackWeapon==4)
                {
                    where = new Vector2(parent.transform.localPosition.x, parent.transform.localPosition.y + 1);
                    Instantiate(Back, where, Quaternion.identity);


                }

                else if (AttackWeapon == 2)
            {
                    where = new Vector2(parent.transform.localPosition.x - 1, parent.transform.localPosition.y);
                    Instantiate(Left, where, Quaternion.identity);

                }

                else if (AttackWeapon == 1)
            {
                    where = new Vector2(parent.transform.localPosition.x + 1, parent.transform.localPosition.y);
                    Instantiate(Right, where, Quaternion.identity);

                }
                else if (AttackWeapon == 3)
            {
                    where = new Vector2(parent.transform.localPosition.x, parent.transform.localPosition.y - 1);
                    Instantiate(Front, where, Quaternion.identity);

                }

            audioSrc.Play(0);   
            //Weapon firing logic goes here.
        }

        
    }
}

