using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalCony : MonoBehaviour
{

    // Use this for initialization
    [SerializeField] private string nextSceneName;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        GameController.GamePoints = GameController.LevelPoints;
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            if (nextSceneName != null)
                SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
        }
    }
}
