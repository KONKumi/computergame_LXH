using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftArrow : MonoBehaviour
{
    public float moveSpeed = 1;

    // Start is called before the first frame update

    void Update()
    {

        transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}
