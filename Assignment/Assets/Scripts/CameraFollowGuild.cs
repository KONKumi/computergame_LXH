using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowGuild : MonoBehaviour
{
    public Transform player;
    float xWidthC = 5.31f;
    float yHeightC = 4.94f;
    float negXWidthC = -4.69f;
    float negYHeightC = 0f;

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