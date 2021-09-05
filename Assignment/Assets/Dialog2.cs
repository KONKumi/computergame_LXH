using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject textbox;

    void Start()
    {
        textbox.SetActive(false);

        sentences[0] = "You\nHi sofia, I back";
        sentences[1] = "Sofia\nIts you! What did you do after you leave?";
        sentences[2] = "You\n(telling the story......)";
        sentences[3] = "Sofia\nOh, it turns out that the people behind the scene is guild master!";
        sentences[4] = "Sofia\nYou want to find him?";
        sentences[5] = "You\nYes...but I think I need to improve myself before I go to find him";
        sentences[6] = "Sofia\njust right, I know that the west side have a forest, at the end of the forest there is a trail dragon";
        sentences[7] = "Sofia\nIf u pass the trail, u will get a mystery force which will help u to improve yourself!";
        sentences[8] = "You\nAlright, I will go there for trail!";
        sentences[9] = "Sofia\nBye, see you!";


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