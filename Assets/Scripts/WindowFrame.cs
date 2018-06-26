using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowFrame : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private GameObject projectile;
    [SerializeField] private Vector3 offset = new Vector3(0,-0.5f,0.5f);


    [SerializeField] private Texture frameWithoutGobl;
    [SerializeField] private Texture frameGobl;
    private Renderer rend;
    private bool isGobl =false;

    void Start () {
        StartCoroutine(Shoot());
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if(isGobl)
        {
            rend.material.mainTexture = frameGobl;
        }
        else
        {
            rend.material.mainTexture = frameWithoutGobl;
        }
        
    }

    private IEnumerator Shoot()
    {
        //yield return new WaitForSeconds(1);
        if (projectile != null)
        {
            while (true)
            {
                isGobl = false;
                yield return new WaitForSeconds(1.5f);
                Instantiate(projectile, new Vector3(transform.position.x+offset.x,transform.position.y + offset.y,transform.position.z + offset.z),Quaternion.identity);
                
                isGobl = true;
                yield return new WaitForSeconds(1.5f);
            }
        }
    }
}
