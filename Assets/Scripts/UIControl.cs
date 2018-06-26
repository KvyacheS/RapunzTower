using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private GameObject menu;
    public GameObject resumeButton;
    public Text HealthField;
    public Text ScoreField;
    public Text gameOverText;
    private bool isMenuOpen;
    private GameController gc;
    [SerializeField] private Player player;

	void Start () {
        isMenuOpen = false;
        if(menu!= null)
        {
            menu.SetActive(false);
        }
        if (HealthField != null)
        {
            HealthField.text = "HEALTH: " + player.GetHealth().ToString();
        }
        if (ScoreField != null)
        {
            ScoreField.text = "SCORE: " + player.GetPoints().ToString();
        }
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
        gc = FindObjectOfType<GameController>();
    }
    // Update is called once per frame
	void Update () {
        if (HealthField != null)
        {
            HealthField.text = "HEALTH: " + player.GetHealth().ToString();
        }
        if (ScoreField != null)
        {
            ScoreField.text = "SCORE: " + player.GetPoints().ToString();
           
        }

    }


    public void OnOpenMenu()
    {
        
        if (menu != null)
        {
            if (player.GetHealth() <= 0)
            { 
                if ((resumeButton != null) && (player.GetHealth() <= 0))
                    resumeButton.SetActive(false);
                if (gameOverText != null)
                    gameOverText.gameObject.SetActive(true);
            }
            isMenuOpen = !isMenuOpen;
            menu.SetActive(isMenuOpen);
            GameController.SetPause(isMenuOpen);
           // player.gameObject.SetActive(!isMenuOpen);
        }    
       
    }
    
    public void OnRestartLevel()
    {
        GameController.SetPause(false);
        player.SetIsRestart(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);      
    }

    public void OnExitToMainMenu()
    {
        Destroy(gc);
        SceneManager.LoadScene("GameMenu", LoadSceneMode.Single);
    }

    public void OnExitFromGame()
    {
        Application.Quit();
    }

    public void OnStartGame()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
