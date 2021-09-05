using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beg : MonoBehaviour
{
    public GameObject insideBeg;
    int check = 0;
    public AudioClip click;
    public AudioClip unclick;
    static AudioSource audioSrc;
    

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        insideBeg.SetActive(false);
    }
    public void beg()
    {
        if (check==0)
        {
            audioSrc.PlayOneShot(click);
            insideBeg.SetActive(true);
            check++;
        }
        else if (check==1)
        {
            audioSrc.PlayOneShot(unclick);
            insideBeg.SetActive(false);
            check--;
        }
    }

    
}
