using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pebel : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private int damage=10;
    [SerializeField] private float lifeTimeOverall = 10.0f;
    [SerializeField] private float lifeTimeAfterCollide = 3.0f;
	void Start () {
        StartCoroutine(Vanish(lifeTimeOverall));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.changeHealth(-damage);
            StartCoroutine(Vanish(lifeTimeAfterCollide));
        }
    }

    private IEnumerator Vanish(float sec = 3.0f)
    {
        yield return new WaitForSeconds(sec);
        Destroy(gameObject);
    }
}
