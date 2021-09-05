using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterHp : MonoBehaviour
{
    public static float gangsterhp = 2f;
    public static float cadrehp = 10f;
    public static float satanhp = 50f;
    public GameObject askhanNoFight;
    public GameObject cadreNoFight;
    public GameObject block;
    GameController gc;
    CheckCadre cc;

    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        cc = GameObject.FindGameObjectWithTag("Check").GetComponent<CheckCadre>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {

            if (this.gameObject.CompareTag("Gangster"))
            {
                gangsterhp -= 2;
                

            }
            else if (this.gameObject.CompareTag("Cadre"))
            {
                cadrehp -= 2;


            }
            else if (this.gameObject.CompareTag("Satan"))
            {
                satanhp -= 2;


            }





        }
    }
   
    void Update()
    {
        if (gangsterhp <= 0)
        {
            Destroy(this.gameObject);
            askhanNoFight.SetActive(true);
            gc.addGold(50);
        }
        if (cadrehp <= 0)
        {
            Destroy(this.gameObject);
            cadreNoFight.SetActive(true);
            block.SetActive(true);
            gc.addGold(100);
            cc.add(1);
        }
        if (satanhp <= 0)
        {
            Destroy(this.gameObject);
            gc.addGold(500);
           
        }

    }

}
