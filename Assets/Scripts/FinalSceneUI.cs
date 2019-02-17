using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalSceneUI : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private Text scoreTxt;
    //[SerializeField] private GameController gc;
	void Start () {
        //gc = FindObjectOfType<GameController>();
		if(scoreTxt != null)
            scoreTxt.text += " " + GameController.GamePoints;  
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnExitToMenu()
    {
        GameController.GamePoints = 0;
        Destroy(GameController.instance);
        SceneManager.LoadScene("GameMenu", LoadSceneMode.Single);
    }
    public void OnExitFromGame()
    {
         Application.Quit();
    }

}
