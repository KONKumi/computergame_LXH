using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoint;

    public Animator animator;
    public float moveSpeed = 1f;
    private int waypointIndex = 0;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoint[waypointIndex].transform.position;

    }


    private void followPath()
    {
        if(waypointIndex<=waypoint.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
        
        if(transform.position== waypoint[waypointIndex].transform.position)
        {
            waypointIndex++;
        }
        }
        if (waypointIndex == waypoint.Length)
        {
            waypointIndex = 0;
        }
    }
    private void checkAnimDirection()
    {
        if (waypointIndex == 1)
            animator.SetInteger("moveDir", 4);
        else if (waypointIndex == 2)
            animator.SetInteger("moveDir", 1);
        else if (waypointIndex == 3)
            animator.SetInteger("moveDir", 3);
        else
            animator.SetInteger("moveDir", 2);

    }
    // Update is called once per frame
    void Update()
    {
        checkAnimDirection();
            followPath();
    }
}
