using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{

    float xWidthP=16.49f;
    float yHeightP=5.9f;
    float negXWidthP=-12f;
    float negYHeightP=-10.26f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, negXWidthP, xWidthP),
            Mathf.Clamp(transform.position.y, negYHeightP, yHeightP), 0);
    }
}

