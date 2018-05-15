using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusRotate : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private float xSpeed = 0f;
    [SerializeField] private float ySpeed = 0f;
    [SerializeField] private float zSpeed = 0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(xSpeed, ySpeed, zSpeed);
        //transform.RotateAround(transform.position, Vector3.up, 20f);
	}
}
