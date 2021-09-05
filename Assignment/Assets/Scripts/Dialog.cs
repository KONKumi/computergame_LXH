using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject textbox;

    void Start()
    {
        textbox.SetActive(false);
       
        sentences[0] = "You\nWhat happened just now ?";
        sentences[1] = "Girl\nThe gangster come to collect tax...we don't have enough money to pay him, so he came and bully us...(crying)....";
        sentences[2] = "You\nDon't cry, I will help you";
        sentences[3] = "You\nI hate this kind of bully weak, I will find him to ask about who instigated him to bully u";
        sentences[4] = "Girl\nThank you so much, my name is Sofia, I know where to find him";
        sentences[5] = "Sofia\nHe live in the Cave at the north side, you can go there to look for him";
        sentences[6] = "You\nOkay, I will go now";
        sentences[7] = "Mission\n(Go to the Cave to find the Gangster)";


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

        if (index == 8)
        {
            textbox.SetActive(false);
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