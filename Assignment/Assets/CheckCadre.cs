using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCadre : MonoBehaviour
{
    public static int check = 0;
    public GameObject Cadre;
    public GameObject Mom2;
    // Start is called before the first frame update
    void Start()
    {
        Mom2.SetActive(false);
        if (check==1)
        {
            Cadre.SetActive(false);
            Mom2.SetActive(true);
        }
    }

    public void add(int amount)
    {
        check += amount;
    }


}
