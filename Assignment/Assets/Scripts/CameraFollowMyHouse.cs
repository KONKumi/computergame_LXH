using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMyHouse : MonoBehaviour
{
    public Transform player;
    float xWidthC = 0.04f;
    float yHeightC = 0.5f;
    float negXWidthC = 0.04f;
    float negYHeightC = 0.5f;

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
