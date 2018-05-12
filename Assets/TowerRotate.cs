using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotate : MonoBehaviour {

	// Use this for initialization

    [SerializeField] private float rotateSpeed = 2.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xAxis;
        xAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0, rotateSpeed * xAxis, 0);
	}
}
