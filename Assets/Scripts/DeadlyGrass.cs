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
        if (GameController.paused == false)
            transform.Translate(0, vertSpeed, 0);       
    }

    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.Health -= 100;
            vertSpeed = 0;
        }else
            Destroy(other.gameObject);
    }
}
