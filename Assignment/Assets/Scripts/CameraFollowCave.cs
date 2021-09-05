using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCave : MonoBehaviour
{
    public Transform player;
    float xWidthC = 1.65f;
    float yHeightC = 3.42f;
    float negXWidthC = -2.46f;
    float negYHeightC =-2.37f;

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