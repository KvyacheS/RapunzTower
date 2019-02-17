using UnityEngine;


public class GameController : MonoBehaviour {

    // Use this for initialization
    public static GameController instance = null;

    public static int LevelPoints = 0;
    public static int GamePoints = 0;
    public static bool paused = false;
    public static bool gameover = false;

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
            paused = true;
        }
        else
        {
            Time.timeScale = 1;
            paused = false;
        }
    }

}
