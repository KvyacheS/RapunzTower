using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalCony : MonoBehaviour
{

    // Use this for initialization
    [SerializeField] private string nextSceneName;
    //[SerializeField] private Scene nextScene;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            if (nextSceneName != null)
                SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            if (nextSceneName != null)
                SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
        }
    }
}
