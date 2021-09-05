using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public AudioClip buttonHitSounds;
    static AudioSource audioSrc;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("RPGLV1");
    }

    public void playGame()
    {
        StartCoroutine(Wait());
        audioSrc.PlayOneShot(buttonHitSounds);
    }

    public void quitGame()
    {
        Application.Quit();
        audioSrc.PlayOneShot(buttonHitSounds);
    }
}
