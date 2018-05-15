using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    // Use this for initialization
    public static GameController instance = null;
    //private
    private int level = 1;

    public int points = 0;

    public int health = 100;

    //[SerializeField] public GameObject retButton;
   // [SerializeField] public GameObject menu;

    void Awake () {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}
    public static void SetPause(bool isPaused)
    {
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;           
        }
    }

}
