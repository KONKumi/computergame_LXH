using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenningDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject textbox;

    void Start()
    {
        textbox.SetActive(true);
        StartCoroutine(Type());
        sentences[1] = "Note\nYou are now in the village";
        sentences[2] = "Note\nYou can go to other place from the village";
        sentences[3] = "Note\nIf u go to the north side, there is a guild house";
        sentences[4] = "Note\nIf u go to the west side, there is a forest, some people say that there is a dragon live at the end of the forest";
        sentences[5] = "Note\nSouth and east are block by the trees, u can't go over the trees";

        sentences[6] = "Note\nPotion shop is at the bottom right corner, you can always go there for some potion before you start your journey";
        sentences[7] = "Note\nThe house at your back is your house, u can take a rest in your house to restore hp";
        sentences[8] = "Note\nTop right corner of your screen is the minimap, and top left corner is your gold and bag"; 
        sentences[9] = "Note\nThe rest you can explore by yourself,Have fun and good luck!";
        sentences[10] = "Girl\nwuwuwu......(crying)......";
        sentences[11] = "Note\nLooks like something happened! Quickly go and see!";
        sentences[12] = "Mission\n(Go to Sofia house to see what happenned)";


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

        if (index == 13)
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