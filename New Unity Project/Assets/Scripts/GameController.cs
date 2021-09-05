using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public string gameOver;
    public TextMeshProUGUI text;
    public TextMeshProUGUI victoryText;
    public int score = 0;
    public static float health = 13f;


    public void changeScore(int gemValue)
    {
        score += gemValue;
        text.text = score.ToString();

        if(score>=100)
        {
            victoryText.text = "Well Done!";
        }

    }
    public void addHealth(float amount)
    {
  
            health += amount;
        
    }
    public void attackPlayer(float damage)
    {
        if(health>0)
        { 
        health -= damage;
        }
        if (health <= 0)
        {
      
            SceneManager.LoadScene(gameOver);
            addHealth(13f);

        }

    }

   
   
}
