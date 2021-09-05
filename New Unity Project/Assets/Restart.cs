using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string restart;
    public Animator animator;
    GameController gc;
    float check;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Restart", Input.GetAxis("Restart"));
        check = animator.GetFloat("Restart");
        if (check==1)
        {
         
            SceneManager.LoadScene(restart);
      



        }

    }
}