using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Animator parent;
   
   
    public GameObject Front;
    public GameObject Back;
    public GameObject Right;
    public GameObject Left;
    Vector2 where;
    float fireRate = 1.0f;
    private float nextFire;
   

    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.GetComponentInParent<Animator>();
     

    }


    // Update is called once per frame
    void Update()
    {
        float AttackWeapon = Input.GetAxis("AttackWeapon");

        if (AttackWeapon == 1)
        {
            if (Input.GetButton("AttackWeapon") && Time.time > nextFire)
            {

                //If the player fired, reset the NextFire time to a new point in the future.
                nextFire = Time.time + fireRate;
                if (parent.GetCurrentAnimatorStateInfo(0).IsName("playerattackbackweapon"))
                {
                    where = new Vector2(parent.transform.localPosition.x, parent.transform.localPosition.y + 1);
                    Instantiate(Back, where, Quaternion.identity);


                }

               else if (parent.GetCurrentAnimatorStateInfo(0).IsName("playerattackleftweapon"))
                {
                    where = new Vector2(parent.transform.localPosition.x - 1, parent.transform.localPosition.y);
                    Instantiate(Left, where, Quaternion.identity);

                }

               else if (parent.GetCurrentAnimatorStateInfo(0).IsName("playerattackrightweapon"))
                { 
                    where = new Vector2(parent.transform.localPosition.x + 1, parent.transform.localPosition.y);
                Instantiate(Right, where, Quaternion.identity);

            }
                else if (parent.GetCurrentAnimatorStateInfo(0).IsName("playerattackfrontweapon"))
                {
                where = new Vector2(parent.transform.localPosition.x, parent.transform.localPosition.y - 1);
                Instantiate(Front, where, Quaternion.identity);

            }


                //Weapon firing logic goes here.
              
                Debug.Log("Firing once every 1s");
            }

        }
    }
}

