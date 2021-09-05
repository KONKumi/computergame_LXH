using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GangsterHp : MonoBehaviour
{
    public static float gangsterhp = 2f;
    GameController gc;
    public GameObject askhanNoFight;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {

            if (this.gameObject.CompareTag("Gangster"))
            {
                gangsterhp -= 2;


            }
        }
    }
            // Update is called once per frame
            void Update()
          {
            if (gangsterhp <= 0)
            {
                Destroy(this.gameObject);
                askhanNoFight.SetActive(true);
                gc.addGold(50);
            }
            }
    }
