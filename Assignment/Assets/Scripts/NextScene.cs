using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string nextLevel;
   
    // Start is called before the first frame update
  
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            SceneManager.LoadScene(nextLevel);
        }
    }
   
}
