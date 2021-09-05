using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class useItem : MonoBehaviour
{
    public static int smallpotion = 5;
    public static int bigpotion = 5;
    GameController gc;
    public TextMeshProUGUI smallamount;
    public TextMeshProUGUI  bigamount;
    public int checkgold;
    public AudioClip buyitem;
    public AudioClip swallow;
    static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }

    public void useSmallPotion()
    {
        
       if (smallpotion > 0 )
        {
            audioSrc.PlayOneShot(swallow);
            smallpotion--;
            gc.addHealth(3f);

        }
        changeSmall(smallpotion);
    }


    public void buySmallPotion()
    {
        checkgold = gc.checkSmall();
        if(checkgold==1)
        {
            gc.minGold(30);
            addSmallPotion();
            audioSrc.PlayOneShot(buyitem);
        }
     

    }

    public void buyBigPotion()
    {
        checkgold = gc.checkBig();
        if (checkgold==1) { 
        gc.minGold(50);
        addBigPotion();
        audioSrc.PlayOneShot(buyitem);
        }
    }

    public void useBigPotion()
    {
        if (bigpotion > 0)
        {
            audioSrc.PlayOneShot(swallow);
            bigpotion--;
            gc.addHealth(6f);
          

        }
        changeBig(bigpotion);
    }

    public void addSmallPotion()
    {
        
         smallpotion++;   
        changeSmall(smallpotion);
    }
    public void addBigPotion()
    {

        bigpotion++;



        changeBig(bigpotion);
    }
    public void changeSmall(int value)
    {
        smallamount.text = value.ToString();
        
    }

    public void changeBig(int value2)
    {
        bigamount.text = value2.ToString();

    }
}
