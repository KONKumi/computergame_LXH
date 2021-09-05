using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible: MonoBehaviour
{
    GameController gc,ed;
    int gemValue;
    public AudioClip collect;
    static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();

    }

    void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            if (this.gameObject.CompareTag("Gems"))
            
               
                gemValue = 10;
            

            else if (this.gameObject.CompareTag("Gems2"))

                gemValue = 20;


            else if (this.gameObject.CompareTag("Gems3"))

                gemValue = 30;
              
            
            
            gc.changeScore(gemValue);
                Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(collect, transform.position);

            Debug.Log("Enter Collider Gem");

            }
        }
    
}
