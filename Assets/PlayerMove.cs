using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private float vertSpeed = 0.1f;
    [SerializeField] private float horiSpeed = 0.1f;
    [SerializeField] private Vector3 Rotatepoint = new Vector3(0f,0f,0f);
    [SerializeField] private float angle = 1f;
    private Animator animator;
    private BoxCollider coll;
    void Start () {
        animator = GetComponent<Animator>();
        coll = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        float yAxis = Input.GetAxis("Vertical");
        if (yAxis != 0)
        {
            animator.SetBool("VertMotion", true);
            if (yAxis>0)
            {
                animator.SetBool("Down", false);
            }
            else
            {
                animator.SetBool("Down", true);
            }
        }
        else
        {
            animator.SetBool("VertMotion", false);
        }
        transform.Translate(0, yAxis*vertSpeed, 0);

        float xAxis = Input.GetAxis("Horizontal");
        if (xAxis != 0)
        {
            animator.SetBool("HoriMotion", true);
            if (xAxis>0)
            {
                animator.SetBool("ReverseSide", false);
            }
            else
            {
                animator.SetBool("ReverseSide", true);
            }
        }
        else
        {
            animator.SetBool("HoriMotion", false);
        }

        if ((yAxis == 0) && (xAxis == 0))
        {
            coll.center = Vector3.MoveTowards(coll.center, new Vector3(0, 1.44f, 0), 0.1f);
        }
        else
        {
            if(yAxis == 0)
            {
                coll.center = Vector3.MoveTowards(coll.center, new Vector3(0, 2.0f, 0), 0.1f);
            }
            else if (yAxis>0)
            {
                coll.center = Vector3.MoveTowards(coll.center, new Vector3(0, 1.70f, 0), 0.1f);
            }
            else
            {            
                coll.center = Vector3.MoveTowards(coll.center, new Vector3(0, 2.85f, 0), 0.1f);
            }
        }
        transform.RotateAround(Rotatepoint, new Vector3(0f, -horiSpeed*xAxis, 0f), angle);
    }
}
