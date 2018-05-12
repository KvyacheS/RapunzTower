using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowFrame : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private GameObject projectile;
    [SerializeField] private float verticalOffset = 0f;
    [SerializeField] private float horizontalOffset = 0f;
    [SerializeField] private float diagonalOffset = 0f;

    void Start () {
        StartCoroutine(Shoot());
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private IEnumerator Shoot()
    {
        //yield return new WaitForSeconds(1);
        if (projectile != null)
        {
            while (true)
            {
                yield return new WaitForSeconds(3);
                Instantiate(projectile);
                Instantiate(projectile, new Vector3(transform.position.x+horizontalOffset,transform.position.y + verticalOffset,transform.position.z + diagonalOffset),Quaternion.identity);
                Debug.Log("mazafaka");
            }
        }
    }
}
