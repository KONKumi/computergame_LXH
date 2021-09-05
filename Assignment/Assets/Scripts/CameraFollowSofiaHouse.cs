using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSofiaHouse : MonoBehaviour
{
    public Transform player;
    float xWidthC = 3.27f;
    float yHeightC = 1.49f;
    float negXWidthC = -2.4f;
    float negYHeightC = -2.07f;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, negXWidthC, xWidthC),
           Mathf.Clamp(player.position.y, negYHeightC, yHeightC), transform.position.z);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}