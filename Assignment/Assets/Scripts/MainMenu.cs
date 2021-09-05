using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    public AudioClip buttonHitSounds;
    static AudioSource audioSrc;
    public GameObject Map;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        Map.SetActive(false);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Village");
    }

    public void playGame()
    {
        StartCoroutine(Wait());
        audioSrc.PlayOneShot(buttonHitSounds);
    }
    IEnumerator reviveScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Revive");
    }
    IEnumerator returnMenu()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Menu");
    }


    public void minimap()
    {
        Map.SetActive(true);
        audioSrc.PlayOneShot(buttonHitSounds);
    }

    public void closeminimap()
    {
        Map.SetActive(false);
        audioSrc.PlayOneShot(buttonHitSounds);
    }

    public void revive()
    {
        StartCoroutine(reviveScene());
        audioSrc.PlayOneShot(buttonHitSounds);
    }

    public void Menu()
    {
        StartCoroutine(returnMenu());
        audioSrc.PlayOneShot(buttonHitSounds);
    }

    public void quitGame()
    {
        Application.Quit();
        audioSrc.PlayOneShot(buttonHitSounds);
    }
}

