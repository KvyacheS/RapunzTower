using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCollect : MonoBehaviour {

    
    public enum EffectType {Score = 1,
                            Invisibility = 2,
                            Life = 3
                           }
    [SerializeField] private EffectType effect= EffectType.Score;
    [SerializeField] private int points = 100;
    [SerializeField] private int life = 10;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>(); 
        if (player != null)
        {
            switch (effect)
            {
                case EffectType.Score:
                    Debug.Log("score");
                    break;
                case EffectType.Invisibility:
                    Debug.Log("Invisiability");
                    break;
                case EffectType.Life:
                    Debug.Log("Life");
                    break;
            }
            Destroy(gameObject);
        }
    }
}
