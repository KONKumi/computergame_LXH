using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public string gameOver;
    public static float health = 13.20865f;
    public static int gold = 100;
    public TextMeshProUGUI goldtext;
 

    void Start()
    {
        goldtext.text = gold.ToString();
     
    }

    public void addHealth(float amount)
    {

        health += amount;
        if (health>= 13.20865f)
            health= 13.20865f;

    }
    public void addGold(int amount)
    {

        gold += amount;
        goldtext.text = gold.ToString();

    }
    public void minGold(int amount)
    {

        gold -= amount;
        goldtext.text = gold.ToString();

    }

  public int checkSmall()
    {
        if (gold >= 30)
            return 1;
        else
            return 2;
    }

   public int checkBig()
    {
        if (gold >= 50)
            return 1;
        else
            return 2;
    }

    public void attackPlayer(float damage)
    {
        if (health > 0)
        {
            health -= damage;
        }


        if (health <= 0)
        {
            addHealth(13.20865f);
            SceneManager.LoadScene(gameOver);
           

        }

    }



}

