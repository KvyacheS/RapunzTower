using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    public static bool isInvisible;
    public static bool isRestart;
    private int health = 100;
    public  int Health
    {
        get
        {
            return health;
        }
        set
        {
            if(!isInvisible)
                health = Mathf.Clamp(value, 0, 100);            
        }
    }
    [SerializeField] private static float invisTimeInSec = 5.0f;
    [SerializeField] private static UIControl control;

    //public static Player instance;

    /*void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }*/


	void Start () {
        isInvisible = false;
        control = FindObjectOfType<UIControl>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (health == 0)
        {
            if (control != null)
            {
                control.OnOpenMenu();
                GameController.gameover = true;
            }
        }
    }

    public static void SetIsRestart(bool value)
    {
        isRestart = value;
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
    }
}
