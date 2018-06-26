using UnityEngine;


public class GameController : MonoBehaviour {

    // Use this for initialization
    public static GameController instance = null;

    public static int points = 0;


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
