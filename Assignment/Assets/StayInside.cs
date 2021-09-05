using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StayInside : MonoBehaviour
{

    float xWidthP = 0;
    float yHeightP = 0;
    float negXWidthP = 0;
    float negYHeightP = -21.5f;
    public string nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, negXWidthP, xWidthP),
            Mathf.Clamp(transform.position.y, negYHeightP, yHeightP), -10);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(39.5f);
        SceneManager.LoadScene(nextLevel);
    }
}
