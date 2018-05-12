using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pebel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Vanish());
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Vanish());
    }

    private IEnumerator Vanish()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
