using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CadreDialog2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject textbox;
    public GameObject CadreNoFight;
    private static int boss = 1;
   


    void Start()
    {

        sentences[1] = "Cadre\nEven u Can Beat Me, but u won't beat the boss...";
        sentences[2] = "Cadre\nU can't win the power of devil....";
        sentences[3] = "Cadre\nNothing will changes.....wahahahahahahaha!....";
   






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
            Destroy(CadreNoFight);
            boss--;

        }
        textDisplay.text = "";
        StartCoroutine(Type());
    }

    public int checkBoss()
    {
        if (boss == 0)
            return 1;
        else
            return 0;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSentence();
        }
    }
}
