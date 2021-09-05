using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CadreDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject textbox;
    public GameObject Cadre;
    public GameObject CadreFight;
    public GameObject CadreNoFight;
    Vector2 wheretoSpawn;
    void Start()
    {
        textbox.SetActive(false);
        CadreFight.SetActive(false);
        CadreNoFight.SetActive(false);
        sentences[1] = "Cadre\nIs someone there?";
        sentences[2] = "Cadre\n.......you look very hostile";
        sentences[3] = "Cadre\nseen like you already know everything";
        sentences[4] = "Cadre\nStop talking nonsense, let's fight";






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

        if (index == 5)
        {

            textbox.SetActive(false);
            CadreFight.SetActive(true);
            Destroy(Cadre);

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