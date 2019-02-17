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
                   // Debug.Log("score");
                    GameController.LevelPoints += points;
                    break;
                case EffectType.Invisibility:
                   // Debug.Log("Invisiability");
                    player.MakeInvisible();
                    break;
                case EffectType.Life:
                   // Debug.Log("Life");
                    GameController.LevelPoints += points;
                    player.Health += life;
                    break;
            }
            Destroy(gameObject);
        }
    }
}
