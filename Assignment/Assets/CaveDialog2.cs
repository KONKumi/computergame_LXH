using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CaveDialog2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject textbox;
    
   
    void Start()
    {
        
        sentences[1] = "Gangster\nOne hit Ko...Sry boss! Don't Bully me!";
        sentences[2] = "You\nTell me your name";
        sentences[3] = "Gangster\nMy name is Askhan, i live in the cave from many years ago";
        sentences[4] = "You\nWho instruct you to bully sofia, tell me if you don't want to die";
        sentences[5] = "Askhan\nIs the cadre of the Guild, He instruct me to bully sofia!";
        sentences[6] = "Askhan\nI Tell you already, don't bully me! ";
        sentences[7] = "You\nNo next time, if not I will find you again";
        sentences[8] = "Askhan\nThanks boss! ";
        sentences[9] = "Mission\n(Go Cadre House to find Cadre)";







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

        if (index == 10)
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
