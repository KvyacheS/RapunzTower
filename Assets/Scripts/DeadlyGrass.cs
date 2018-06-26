using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyGrass : MonoBehaviour {

	// Use this for initialization
    [SerializeField] float vertSpeed = 1.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, vertSpeed, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        WindowFrame wf = other.GetComponent<WindowFrame>();
        Pebel pb = other.GetComponent<Pebel>();
        if (player != null)
        {
            player.changeHealth(-100);
            vertSpeed = 0;
        }
        if(wf != null)
        {
            Destroy(wf.gameObject);
        }
        if (pb != null)
        {
            Destroy(pb.gameObject);
        }
    }
}
