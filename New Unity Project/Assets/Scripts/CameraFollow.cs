using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    float xWidthC = 12f;
    float yHeightC = 3.2f;
    float negXWidthC = -8.1f;
    float negYHeightC = -7.3f;
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
