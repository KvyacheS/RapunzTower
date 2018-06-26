using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    public bool isInvisible;
    public bool isRestart;
    [SerializeField] private int health=100;
    [SerializeField] private int levelPoints=0;
    [SerializeField] private float invisTimeInSec = 5.0f;
    [SerializeField] private UIControl control;

	void Start () {
        isInvisible = false;
        levelPoints += GameController.points;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeHealth(int value)
    {
        if ((value < 0) && isInvisible)
            return;
        if (health + value > 100)
            return;
        health += value;
        if (health <= 0)
        {
            if (control != null)
            {
                control.OnOpenMenu();
            }
        }
    }

    public void SetIsRestart(bool value)
    {
        isRestart = value;
    }
    public int GetHealth()
    {
        return health;
    }

    public int GetPoints()
    {
        return levelPoints;
    }
    public void changePoints(int value)
    {
        levelPoints += value;
    }
    public IEnumerator MakeInvisible()
    {
        isInvisible = true;
        yield return new WaitForSeconds(invisTimeInSec);
        isInvisible = false;
    }
   
    void OnDestroy()
    {
        if (isRestart)
            return;
        GameController.points = levelPoints;
    }
}
