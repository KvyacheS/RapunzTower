using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private GameObject menu;

    private bool isMenuOpen;

	void Start () {
        isMenuOpen = false;
        if(menu!= null)
        {
            menu.SetActive(false);
        }      
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnOpenMenu()
    {
        isMenuOpen = !isMenuOpen;
        menu.SetActive(isMenuOpen);
        GameController.SetPause(isMenuOpen);
    }

    public void OnRestartLevel()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void OnExitToMainMenu()
    {
        SceneManager.LoadScene("GameMenu", LoadSceneMode.Single);
    }

    public void OnExitFromGame()
    {
        Application.Quit();
    }

    public void OnStartGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
