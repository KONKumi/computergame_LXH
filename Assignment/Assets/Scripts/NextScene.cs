using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string nextLevel;
    public Animator animator;
    // Start is called before the first frame update
  
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("isOpen", true);
            SceneManager.LoadScene(nextLevel);
        }
    }
   
}
