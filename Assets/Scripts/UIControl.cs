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
    [SerializeField] private Player player;

	void Start () {
        isMenuOpen = false;
        if(menu!= null)
            menu.SetActive(false);

        if (HealthField != null)
            HealthField.text = "HEALTH: " + player.Health.ToString();

        if (ScoreField != null)
            ScoreField.text = "SCORE: " +  GameController.LevelPoints.ToString();

        if (gameOverText != null)
            gameOverText.gameObject.SetActive(false);
    }
    // Update is called once per frame
	void Update () {
        if (HealthField != null)
            HealthField.text = "HEALTH: " + player.Health.ToString();

        if (ScoreField != null)
            ScoreField.text = "SCORE: " + GameController.LevelPoints.ToString();        
    }

    public void OnOpenMenu()
    {
        if (GameController.gameover == true)
            return;
        if (menu != null)
        {
            if (player.Health <= 0)
            { 
                if ((resumeButton != null) && (player.Health <= 0))
                    resumeButton.SetActive(false);
                if (gameOverText != null)
                    gameOverText.gameObject.SetActive(true);
            }
            isMenuOpen = !isMenuOpen;
            menu.SetActive(isMenuOpen);
            GameController.SetPause(isMenuOpen);
        }         
    }
    
    public void OnRestartLevel()
    {
        GameController.gameover = false;
        GameController.SetPause(false);
        Player.SetIsRestart(true);        
        GameController.LevelPoints = GameController.GamePoints;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);      
    }

    public void OnExitToMainMenu()
    {
        Destroy(GameController.instance);
        GameController.GamePoints = 0;
        SceneManager.LoadScene("GameMenu", LoadSceneMode.Single);
    }

    public void OnExitFromGame()
    {
        Application.Quit();
    }

    public void OnStartGame()
    {
        GameController.GamePoints = 0;
        GameController.LevelPoints = 0;
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
