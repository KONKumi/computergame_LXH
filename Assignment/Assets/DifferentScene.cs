using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifferentScene : MonoBehaviour
{
    public string nextLevel;
    public string anotherLevel;
    int boss;
    CadreDialog2 cd;

    // Start is called before the first frame update


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            boss = cd.checkBoss();

            if (boss==0)
            SceneManager.LoadScene(nextLevel);
            else if(boss==1)
                SceneManager.LoadScene(anotherLevel);
        }
    }

}
