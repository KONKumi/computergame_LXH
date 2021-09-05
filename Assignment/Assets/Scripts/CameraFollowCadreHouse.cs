using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCadreHouse : MonoBehaviour
{
    public Transform player;
    float xWidthC = 0.66f;
    float yHeightC = 5.92f;
    float negXWidthC = -0.66f;
    float negYHeightC = -0.53f;

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