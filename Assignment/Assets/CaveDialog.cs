using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CaveDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject textbox;
    public GameObject gangster;
    public GameObject askhan;
    public GameObject askhanNoFight;
    Vector2 wheretoSpawn;
    void Start()
    {
        textbox.SetActive(false);
        askhan.SetActive(false);
        askhanNoFight.SetActive(false);
        sentences[1] = "Gangster\nWho are you!";
        sentences[2] = "Gangster\nYou want to know who calling me to bully sofia?";
        sentences[3] = "Gangster\nHahaha......I will tell u after u beat me!";
  





    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {   
            
            textbox.SetActive(true);
            StartCoroutine(Type());
        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void NextSentence()
    {
        index++;

        if (index == 4)
        {
            
            textbox.SetActive(false);
            askhan.SetActive(true);
            Destroy(gangster);
            
        }
        textDisplay.text = "";
        StartCoroutine(Type());
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSentence();
        }
    }
}